namespace ConsoleApp1;

using System.Text.Json;
using Models;

public static class ConfigManager
{
    private static readonly string WorkspaceDirectoryJson = Path.GetFullPath(@"../../../Resources");
    
    public static List<UserDataModel> _userData;

    public static ErrorDataModel _errorData;

    public static ConfigDataModel _configData;
    
    public static ExpectedDataModel _expectedData;

    public static List<UserDataModel> SetUserData()
    {
        if(_userData == null)
        {
            var fullPath = WorkspaceDirectoryJson + @"\UserData.json";
            var jsonStr = File.ReadAllText(fullPath);
            _userData = JsonSerializer.Deserialize<List<UserDataModel>>(jsonStr);
        }
        
        return _userData;
    }

    public static ErrorDataModel SetErrorData()
    {
        if (_errorData == null)
        {
            var fullPath = WorkspaceDirectoryJson + @"\ExpectedErrorMessages.json";
            var jsonStr = File.ReadAllText(fullPath);
            _errorData = JsonSerializer.Deserialize<ErrorDataModel>(jsonStr);
        }

        return _errorData;
    }
    
    public static ConfigDataModel SetConfigData()
    {
        if (_configData == null)
        {
            var fullPath = WorkspaceDirectoryJson + @"\ConfigData.json";
            var jsonStr = File.ReadAllText(fullPath);
            _configData = JsonSerializer.Deserialize<ConfigDataModel>(jsonStr);
        }

        return _configData;
    }
    
    public static ExpectedDataModel SetExpectedData()
    {
        if (_expectedData == null)
        {
            var fullPath = WorkspaceDirectoryJson + @"\ExpectedData.json";
            var jsonStr = File.ReadAllText(fullPath);
            _expectedData = JsonSerializer.Deserialize<ExpectedDataModel>(jsonStr);
        }

        return _expectedData;
    }
    
    //TODO Move the logics above to generic function thant handles the logic equally
    // Added here for later use as it breaks the test cases when used now!!!
    public static T SetData<T>(string filePath) where T : class
    {
        var fullPath = WorkspaceDirectoryJson + $"\\{filePath}";
        var jsonStr = File.ReadAllText(fullPath);
    
        return JsonSerializer.Deserialize<T>(jsonStr);
    }

    public static EnvironmentModel ReadEnvironment()
    {
        var environment = Environment.GetEnvironmentVariable("environment");
        var fullPath = WorkspaceDirectoryJson + $@"\{environment}.json";
        var jsonStr = File.ReadAllText(fullPath);

        return JsonSerializer.Deserialize<EnvironmentModel>(jsonStr);
    }
}