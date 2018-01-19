// Install addins.
#addin "Cake.IIS"

BuildParameters parameters = BuildParameters.GetParameters(Context);
bool publishingError = false;
DotNetCoreMSBuildSettings msBuildSettings = null;
FilePath signClientPath;

RunTarget(parameters.Target);