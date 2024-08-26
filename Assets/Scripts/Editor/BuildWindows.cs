using System.Linq;
using UnityEditor;

public class BuildWindows
{
    [MenuItem("Build/Windows/Build IL2CPP Release")]
    public static void BuildWindowsIL2CPPRelease()
    {
        PlayerSettings.SetScriptingBackend(BuildTargetGroup.Standalone, ScriptingImplementation.IL2CPP);
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions
        {
            scenes = EditorBuildSettings.scenes.Select(scene => scene.path).ToArray(),
            locationPathName = "Builds/Windows/MyGame.exe", // Set your desired build path
            target = BuildTarget.StandaloneWindows64,
            options = BuildOptions.CompressWithLz4HC,
        };

        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
    
    [MenuItem("Build/Windows/Build")]
    public static void Build()
    {
        PlayerSettings.SetScriptingBackend(BuildTargetGroup.Standalone, ScriptingImplementation.Mono2x);
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions
        {
            scenes = EditorBuildSettings.scenes.Select(scene => scene.path).ToArray(),
            locationPathName = "Builds/Windows/MyGame.exe", // Set your desired build path
            target = BuildTarget.StandaloneWindows64,
            options = BuildOptions.None,
        };

        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
}
