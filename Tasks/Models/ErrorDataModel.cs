namespace ConsoleApp1.Models;

using System.Text.Json.Serialization;

public class ErrorDataModel
{
    [JsonPropertyName("error_text_for_wrong_email_address")]
    public string WrongEmailAddress { get; set; }
    
    [JsonPropertyName("error_text_for_empty_email_address")]
    public string EmptyEmailAddress { get; set; }
    
    [JsonPropertyName("error_text_for_wrong_password")]
    public string WrongPassword { get; set; }
    
    [JsonPropertyName("error_text_for_empty_password")]
    public string EmptyPassword { get; set; }
}