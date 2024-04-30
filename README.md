Just a template project for vs code to create a .net framework project.

# Set up

- vs code + extensions(c# dev kit)
- .net framework 4.8.1
- .net 8.0+

# Commands

```bash
cd HelloDotNetFramework
# search package
dotnet.exe package search MySql
# add package
dotnet.exe add package MySql.Data
# build
dotnet.exe build
dotnet.exe build -c Release
# run
dotnet.exe run
```