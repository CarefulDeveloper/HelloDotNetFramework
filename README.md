Just a template project for vs code to create a .net framework project.

```bash
cd HelloDotNetFramework
# search package
dotnet.exe package search MySql
# add package
dotnet.exe add package MySql.Data
# build
dotnet.exe build
dotnet.exe build -r Release
# run
dotnet.exe run
```