# <Project name>

<project description>

This repo contains the following applications:

- 

## Getting Started

### Prerequesites

Each project is a normal C# Visual Studio 2019 project. At minimum, you need [.NET Core SDK 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1) to build and test the project.

We recommend installing [Visual Studio 2019 v16.3 or later ](https://www.visualstudio.com/vs/) or [Visual Studio Code](https://code.visualstudio.com/) which will set you up with all the .NET build tools and allow you to open the solution files.

### Solution Files
The repo currently has 3 solution files:
- *all.sln*: This includes all the sdk product, test and samples project files.
- *src/prod.sln*: This includes all the product project files.
- *test/test.sln*: This includes all the test projects and dependencies project files.

### Build

To build everything  run dotnet cli commands.

```bash
# Build sdk, samples and tests.
dotnet build -c Debug  # for release, -c Release

# Run unit and integration tests
dotnet test test/test.sln

# Publish deployable application files
dotnet publish src/prod.sln -c Release -r win10-x64
```

Each project can also be built individually directly through Visual Studio. You can open the solution file all.sln in repo root to load all service and test projects.

## Releases


### Generate release ready files locally


## Documentation

These articles will help get you started:

