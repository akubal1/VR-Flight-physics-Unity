using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEditor.iOS.Xcode;

 private const string TouchedMarker = "https://github.com/jiulongw/swift-unity#v1";

    [PostProcessBuild]
    public static void OnPostBuild(BuildTarget target, string pathToBuiltProject)
    {
        if (target != BuildTarget.iOS)
        {
            return;
        }

        PatchUnityNativeCode(pathToBuiltProject);

        UpdateUnityIOSExports(pathToBuiltProject);

        UpdateUnityProjectFiles(pathToBuiltProject);
    }
