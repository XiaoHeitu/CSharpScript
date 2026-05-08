(() => {
  const host = globalThis.testHost ?? (globalThis.testHost = {});
  const state = {
    calls: {},
    originals: {},
    completed: false,
    failed: -1,
    total: 0,
  };

  const fixtureHtml = `
    <style id="test-style">
      #parent { background-color: rgb(255, 0, 0); padding: 4px; }
      .item { color: blue; display: inline-block; }
      .box { border: 1px solid black; }
    </style>
    <section id="container" class="outer wrapper" data-kind="root">
      <div id="parent" class="box alpha" name="parentName" data-role="parent" style="width: 120px; height: 80px; overflow: auto;">
        <span id="first" class="item alpha" name="childName">first</span>
        <span id="second" class="item beta">second</span>
        <p id="third" class="item gamma">third</p>
      </div>
      <form id="sampleForm" name="sampleForm"></form>
      <a id="link1" name="anchorName" href="#hash">anchor</a>
      <img id="image1" alt="image" />
    </section>`;

  function ensureFixture() {
    let fixture = document.getElementById('test-fixture');
    if (!fixture) {
      fixture = document.createElement('div');
      fixture.id = 'test-fixture';
      document.body.appendChild(fixture);
    }
    return fixture;
  }

  function recordCall(name, args) {
    if (!state.calls[name]) {
      state.calls[name] = [];
    }
    state.calls[name].push(Array.from(args));
  }

  function cloneCalls(name) {
    return JSON.stringify(state.calls[name] ?? []);
  }

  function installStub(target, member, impl) {
    const key = `${member}`;
    if (!state.originals[key]) {
      state.originals[key] = target[member];
    }
    target[member] = impl;
  }

  function restoreStubs() {
    for (const [key, original] of Object.entries(state.originals)) {
      if (key in globalThis) {
        globalThis[key] = original;
        continue;
      }

      if (key in console) {
        console[key] = original;
        continue;
      }

      if (key in history) {
        history[key] = original;
        continue;
      }

      if (key in location) {
        try {
          location[key] = original;
        } catch {
        }
      }
    }

    state.originals = {};
  }

  host.resetState = () => {
    restoreStubs();
    state.calls = {};
    state.completed = false;
    state.failed = -1;
    state.total = 0;
    document.title = 'CSharpScript Browser Tests';
    ensureFixture().innerHTML = fixtureHtml;
    localStorage.clear();
    sessionStorage.clear();
    if (globalThis.getSelection) {
      globalThis.getSelection().removeAllRanges();
    }
  };

  host.installWindowStubs = () => {
    installStub(globalThis, 'alert', (...args) => recordCall('alert', args));
    installStub(globalThis, 'confirm', (...args) => {
      recordCall('confirm', args);
      return true;
    });
    installStub(globalThis, 'prompt', (...args) => {
      recordCall('prompt', args);
      return 'prompt-result';
    });
    installStub(globalThis, 'open', (...args) => {
      recordCall('open', args);
      return 'opened-window';
    });
    installStub(globalThis, 'print', (...args) => recordCall('print', args));
    installStub(globalThis, 'scrollTo', (...args) => recordCall('scrollTo', args));
    installStub(globalThis, 'scroll', (...args) => recordCall('scroll', args));
    installStub(globalThis, 'scrollBy', (...args) => recordCall('scrollBy', args));
    installStub(globalThis, 'focus', (...args) => recordCall('focus', args));
    installStub(globalThis, 'blur', (...args) => recordCall('blur', args));
    installStub(globalThis, 'resizeTo', (...args) => recordCall('resizeTo', args));
    installStub(globalThis, 'resizeBy', (...args) => recordCall('resizeBy', args));
    installStub(globalThis, 'moveTo', (...args) => recordCall('moveTo', args));
    installStub(globalThis, 'moveBy', (...args) => recordCall('moveBy', args));
    installStub(globalThis, 'close', (...args) => recordCall('close', args));
    installStub(history, 'back', (...args) => recordCall('history.back', args));
    installStub(history, 'forward', (...args) => recordCall('history.forward', args));
    installStub(history, 'go', (...args) => recordCall('history.go', args));

    try {
      installStub(location, 'assign', (...args) => recordCall('location.assign', args));
      installStub(location, 'replace', (...args) => recordCall('location.replace', args));
      installStub(location, 'reload', (...args) => recordCall('location.reload', args));
    } catch {
      recordCall('location.stub.error', ['unsupported']);
    }
  };

  host.installConsoleStub = () => {
    for (const name of ['log', 'info', 'warn', 'error', 'debug', 'clear', 'trace', 'assert', 'count', 'countReset', 'group', 'groupEnd', 'groupCollapsed', 'time', 'timeEnd', 'timeLog']) {
      installStub(console, name, (...args) => recordCall(`console.${name}`, args));
    }
  };

  host.getCallLogJson = (name) => cloneCalls(name);
  host.getFixtureElement = (selector) => ensureFixture().querySelector(selector);
  host.getFixtureAttributes = (selector) => ensureFixture().querySelector(selector)?.attributes ?? null;
  host.getFixtureRoot = () => ensureFixture();
  host.getTouchObject = (selector) => {
    const target = ensureFixture().querySelector(selector);
    const touch = Object.create(Touch.prototype);
    Object.defineProperties(touch, {
      identifier: { value: 7 },
      target: { value: target },
      clientX: { value: 10 },
      clientY: { value: 20 },
      screenX: { value: 30 },
      screenY: { value: 40 },
      pageX: { value: 50 },
      pageY: { value: 60 },
      radiusX: { value: 11 },
      radiusY: { value: 12 },
      rotationAngle: { value: 13 },
      force: { value: 0.5 },
    });
    return touch;
  };
  host.getTouchListObject = (selector) => {
    const touch = host.getTouchObject(selector);
    const list = Object.create(TouchList.prototype);
    Object.defineProperty(list, 'length', { value: 1 });
    list.item = (index) => index === 0 ? touch : null;
    return list;
  };
  host.getSelectionObject = () => globalThis.getSelection();
  host.setTextSelection = () => {
    const target = ensureFixture().querySelector('#first');
    const textNode = target.firstChild;
    const range = document.createRange();
    range.setStart(textNode, 0);
    range.setEnd(textNode, textNode.textContent.length);
    const selection = globalThis.getSelection();
    selection.removeAllRanges();
    selection.addRange(range);
  };
  host.getStyleSheetListHandle = () => document.styleSheets;
  host.getStyleSheetHandle = (index) => document.styleSheets[index] ?? null;
  host.getCssRuleHandle = (sheetIndex, ruleIndex) => document.styleSheets[sheetIndex]?.cssRules[ruleIndex] ?? null;
  host.getCssRuleListHandle = (sheetIndex) => document.styleSheets[sheetIndex]?.cssRules ?? null;
  host.getFixtureStyleSheetHandle = () => document.getElementById('test-style')?.sheet ?? null;
  host.getFixtureCssRuleHandle = (index) => document.getElementById('test-style')?.sheet?.cssRules[index] ?? null;
  host.getFixtureCssRuleListHandle = () => document.getElementById('test-style')?.sheet?.cssRules ?? null;
  host.createEventObject = (type) => new Event(type, { bubbles: true, cancelable: true });
  host.createReflectTarget = () => ({ name: 'alpha', count: 3, flag: true, rate: 1.5 });
  host.createReflectReceiver = () => ({ receiver: true });
  host.createReflectValueObject = () => ({ nested: 'value' });
  host.createReflectDescriptor = () => ({ value: 'descriptor', configurable: true, enumerable: true, writable: true });
  host.createReflectPrototype = () => ({ protoName: 'proto-value' });
  host.createReflectApplyFunction = () => function (a, b) { return { sum: a + b, selfTag: this && this.tag ? this.tag : 'none' }; };
  host.createReflectThisArgument = () => ({ tag: 'context' });
  host.createReflectArguments = () => [2, 5];
  host.getArrayLength = (value) => value?.length ?? 0;
  host.getArrayItemAsString = (value, index) => String(value[index]);
  host.getObjectPropertyAsString = (value, propertyName) => String(value[propertyName]);
  host.publishSummary = (total, failed) => {
    state.total = total;
    state.failed = failed;
    state.completed = true;
    document.body.dataset.testsComplete = 'true';
    document.body.dataset.testsTotal = String(total);
    document.body.dataset.testsFailed = String(failed);
  };
  host.publishResultsJson = (resultsJson) => {
    document.body.dataset.testsResults = resultsJson;
  };
  host.getSummaryJson = () => JSON.stringify({ total: state.total, failed: state.failed, completed: state.completed });

})();
