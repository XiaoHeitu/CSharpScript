# 🚀 CSharpScript

<p align="center">
  <img src="https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=.net" alt=".NET 8.0">
  <img src="https://img.shields.io/badge/WebAssembly-FFF?logo=webassembly&style=for-the-badge" alt="WebAssembly">
  <img src="https://img.shields.io/badge/platform-browser-wasm-FF6B6B?style=for-the-badge" alt="Platform">
  <img src="https://img.shields.io/github/license/your-username/CSharpScript?style=for-the-badge" alt="License">
</p>

> 将浏览器标准 JavaScript API 完整映射到 C#，让 .NET 开发人员能够使用熟悉的 C# 语法操作浏览器原生功能。

---

## ✨ 特性

- 🔄 **完整的 JS 互操作** - 使用 .NET 7+ 的 `[JSImport]` / `[JSExport` 特性
- 🌐 **纯 WebAssembly** - 无需 Blazor 依赖，轻量级编译输出
- 📦 **类型安全** - 强类型 C# API，覆盖主流浏览器对象
- 🛠️ **开箱即用** - 预置 Window、Console、Document、Storage 等核心 API

---

## 📁 项目结构

```
CSharpScript/
├── src/CSharpScript/
│   ├── CSharpScript.sln
│   └── CSharpScript/
│       ├── CSharpScript.csproj
│       ├── GlobalUsings.cs
│       └── Browser/
│           ├── Window.cs          # window 对象
│           ├── Console.cs         # console 对象
│           ├── Document.cs        # document 对象
│           ├── Location.cs        # location 对象
│           ├── Navigator.cs       # navigator 对象
│           ├── History.cs         # history 对象
│           └── Storage/
│               ├── LocalStorage.cs
│               └── SessionStorage.cs
```

---

## 📊 实现进度

| 模块 | 状态 | 描述 |
|:-----|:----:|:-----|
| **Window** | ✅ 已完成 | alert, confirm, prompt, setTimeout, scroll, resize 等 |
| **Console** | ✅ 已完成 | log, info, warn, error, debug, clear 等 |
| **Document** | 🔄 进行中 | querySelector, getElementById 等 |
| **Location** | ✅ 已完成 | href, pathname, search 等属性 |
| **Navigator** | ✅ 已完成 | userAgent, language, platform 等 |
| **History** | ✅ 已完成 | pushState, replaceState, back, forward 等 |
| **LocalStorage** | ✅ 已完成 | getItem, setItem, removeItem, clear 等 |
| **SessionStorage** | ✅ 已完成 | getItem, setItem, removeItem, clear 等 |

> **总体进度**: 7/8 模块已完成 (87.5%)

---

## 🛠️ 技术栈

<p>

| 技术 | 版本 |
|:-----|:-----|
| .NET SDK | 8.0 |
| 目标框架 | net8.0 |
| 运行时 | browser-wasm |
| 互操作 | JSImport / JSExport |

</p>

---

## 📖 快速开始

### 1. 克隆项目

```bash
git clone https://github.com/your-username/CSharpScript.git
cd CSharpScript
```

### 2. 构建项目

```bash
cd src/CSharpScript
dotnet build
```

### 3. 使用示例

```csharp
using CSharpScript.Browser;

// 控制台输出
Console.Log("Hello from C#!");
Console.Info("This is an info message");
Console.Warn("Warning: something happened");
Console.Error("Error occurred!");

// 窗口操作
Window.Alert("Hello World!");
bool confirmed = Window.Confirm("Are you sure?");
string? input = Window.Prompt("Enter your name:", "Guest");

// 存储 API
LocalStorage.SetItem("user", "John");
string? user = LocalStorage.GetItem("user");
LocalStorage.RemoveItem("user");

// 页面导航
History.PushState(null, "", "/new-page");
History.Back();

// 获取窗口尺寸
int width = Window.GetInnerWidth();
int height = Window.GetInnerHeight();
```

---

## 🔧 项目配置

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <AllowUnsafeBlocks>true</AllowUnsafeBlocks>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
  </PropertyGroup>
</Project>
```

---

## 📝 核心实现模式

```csharp
// 使用 JSImport 导入 JavaScript 函数
[SupportedOSPlatform("browser")]
public static partial class Window
{
    [JSImport("globalThis.window.alert")]
    public static partial void Alert(string message);

    [JSImport("globalThis.window.setTimeout")]
    public static partial int SetTimeout(Action callback, int delay);
}
```

---

## 🤝 贡献指南

欢迎提交 Issue 和 Pull Request！

1. Fork 本仓库
2. 创建特性分支 (`git checkout -b feature/AmazingFeature`)
3. 提交更改 (`git commit -m 'Add some AmazingFeature'`)
4. 推送分支 (`git push origin feature/AmazingFeature`)
5. 开启 Pull Request

---

## 📄 许可证

本项目基于 MIT 许可证开源 - 查看 [LICENSE](LICENSE) 文件了解详情。

---

<p align="center">
  <sub>Made with ❤️ using .NET 8 + WebAssembly</sub>
</p>