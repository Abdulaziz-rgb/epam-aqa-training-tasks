using ConsoleApp1.Logging;
using NUnit.Framework;

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
}