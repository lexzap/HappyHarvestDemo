using System.Linq;
using UnityEditor;

public class BuildWebGL
{
    [MenuItem("Build/WebGL/Build")]
    public static void BuildWebGLRelease()
    {
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions
        {
            scenes = EditorBuildSettings.scenes.Select(scene => scene.path).ToArray(),
            locationPathName = "Builds/WebGL", // Set your desired build path
            target = BuildTarget.WebGL,
            options = BuildOptions.None,
        };

        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
}
