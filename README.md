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

# Interop with ComObject

1. generate interop dll file by `tlbimp.exe`, a .net framework sdk tool.
```bash
cd HelloDotNetFramework/Lib
# example path for TlbImp.exe
& "C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8.1 Tools\TlbImp.exe" "C:\Windows\System32\wshom.ocx" /out:Interop.IWshRuntimeLibrary.dll
```

2. add interop dll to dependencies.