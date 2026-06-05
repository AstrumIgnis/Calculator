# Calculator - Copilot CLI Learning Project

## 📋 Project Overview
This is a **C# calculator application** built entirely using **GitHub Copilot CLI** to showcase its code generation, testing, and refactoring capabilities.

## 🎯 Purpose
This project serves as a **learning playground** to:
- Understand and demonstrate Copilot CLI features (`/plan`, `/review`, `/delegate`, code generation)
- Build a complete calculator from scaffolding to deployment
- Practice test-driven development (TDD) with XUnit
- Learn C# best practices and design patterns through Copilot-assisted development
- Explore CLI vs. GUI implementations (console app expanding to WinForms/WPF)

## 🛠️ Tech Stack
- **Language:** C# (.NET 10.0.204)
- **Framework:** .NET 10
- **Testing:** XUnit
- **IDE:** Visual Studio 2026 / VS Code
- **Version Control:** Git + GitHub
- **Development Tool:** GitHub Copilot CLI (primary development assistant)

## ✨ Features (Planned)
- ✅ Basic arithmetic operations (+, −, ×, ÷)
- ✅ Clear/Reset functionality
- ✅ Error handling (divide by zero, invalid input)
- 🚧 Operation history tracking
- 🚧 Console-based CLI interface
- 🚧 Unit tests (XUnit)
- 🔜 GUI implementation (WinForms/WPF)

## 🚀 Getting Started
### Prerequisites
- .NET 10 SDK or later ([download](https://dotnet.microsoft.com/download))
- Visual Studio 2026 or VS Code with C# extension

### Build & Run
```bash
cd E:\Copilot Projects\Calculator
dotnet build
dotnet run
```

### Open in Visual Studio
```bash
# Open the solution file
E:\Copilot Projects\Calculator\Calculator.sln
```

## 📁 Project Structure
```
Calculator/
├── Calculator.csproj          # Project file
├── Calculator.sln             # Visual Studio solution
├── Program.cs                 # Entry point
├── Core/                      # Core calculator logic (planned)
│   ├── Calculator.cs
│   ├── Operation.cs
│   └── CalculatorException.cs
├── Tests/                     # Unit tests (planned)
│   └── CalculatorTests.cs
└── README.md
```

## 🧪 Testing
```bash
dotnet test
```

## 📚 Learning Goals Achieved
- [ ] Used `/plan` command for implementation planning
- [ ] Used `/review` command for code reviews
- [ ] Used `/delegate` for test generation
- [ ] Practiced Copilot-assisted refactoring
- [ ] Generated documentation with Copilot
- [ ] Learned CLI-based development workflow

## 📝 Notes
This project intentionally uses GitHub Copilot CLI as the primary development tool to learn its capabilities and workflows. It demonstrates how AI-assisted development can accelerate learning and code quality.

## 🔗 Resources
- [GitHub Copilot CLI Docs](https://docs.github.com/copilot/how-tos/use-copilot-agents/use-copilot-cli)
- [.NET 10 Documentation](https://learn.microsoft.com/en-us/dotnet/)
- [C# Learning Path](https://learn.microsoft.com/en-us/training/paths/csharp-first-steps/)

---
**Created with GitHub Copilot CLI** 🤖
