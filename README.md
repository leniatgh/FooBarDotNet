# FooBarDotNet

## Overview

FooBarDotNet is a .NET solution designed to demonstrate how a project can have indirect dependencies on two different packages that define the same class and namespace, but with different implementations. This scenario is common in complex solutions and can lead to subtle runtime issues if not managed carefully.

## Project Structure

- `FooBar/` - Main application project.
- `Foo/` - Library project, depends on `FoosLib`.
- `Bar/` - Library project, depends on `BarsLib`.
- `FoosLib/` - Library providing a class (e.g., `Fake`) in a specific namespace.
- `BarsLib/` - Library providing a class with the same name and namespace as in `FoosLib`, but with a different implementation.

## Dependency Graph

```
FooBar
├── Foo (depends on FoosLib)
│   └── FoosLib (defines e.g., Fake in NamespaceX)
├── Bar (depends on BarsLib)
│   └── BarsLib (defines Fake in NamespaceX, different implementation)
```

## Purpose

This project demonstrates:
- How indirect dependencies can introduce multiple versions of a class with the same name and namespace.
- The potential for conflicts or unexpected behavior at runtime due to type identity issues.
- Best practices for managing such dependencies in .NET projects.

## How to Build

1. Open `FooBar.sln` in Visual Studio or your preferred .NET IDE.
2. Build the solution. All projects will be built and output to their respective `bin/Debug` folders.

## How to Run

1. Set `FooBar` as the startup project.
2. Run the application. Observe the behavior and outputs, which may differ depending on which implementation of the shared class is used.

## Notes

- This project is for demonstration and educational purposes.
- In real-world scenarios, avoid having multiple packages with the same class and namespace unless absolutely necessary.
