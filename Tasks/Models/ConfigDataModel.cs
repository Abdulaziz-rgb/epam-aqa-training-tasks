namespace ConsoleApp1.Models;

using System.Text.Json.Serialization;

public class ConfigDataModel
{
    [JsonPropertyName("browser")]
    public string Browser { get; set; }
    
    [JsonPropertyName("gmail_url")]
    public string GmailUrl { get; set; }
    
    [JsonPropertyName("proton_url")]
    public string ProtonUrl { get; set; }
    
    [JsonPropertyName("new_nickname")]
    public string NewNickname { get; set; }
    
    [JsonPropertyName("message_from_gmail")]
    public string MessageFromGmail { get; set; }
    
    [JsonPropertyName("message_from_proton")]
    public string MessageFromProton { get; set; }
    
    [JsonPropertyName("message_subject_from_gmail")]
    public string MessageSubjectFromGmail { get; set; }
}