using System.Reflection;
using Interop.IWshRuntimeLibrary;

// example code for call ComObject
class ComObjectUtils
{
    public static void CreateShortcutByReflection(string path)
    {
        var WScriptShellType = Type.GetTypeFromProgID("WScript.Shell");
        var instance = Activator.CreateInstance(WScriptShellType);
        var shortcut = WScriptShellType.InvokeMember("CreateShortcut", BindingFlags.InvokeMethod, null, instance, [path]);
        WScriptShellType.InvokeMember("TargetPath", BindingFlags.SetProperty, null, shortcut, ["cmd.exe"]);
        WScriptShellType.InvokeMember("Save", BindingFlags.InvokeMethod, null, shortcut, []);
    }

    public static void CreateShortcutByWrapper(string path)
    {
        var shell = new WshShell();
        WshShortcut shortcut = shell.CreateShortcut(path);
        shortcut.TargetPath = "cmd.exe";
        shortcut.Save();
    }
}