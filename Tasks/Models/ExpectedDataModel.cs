namespace ConsoleApp1.Models;

using System.Text.Json.Serialization;

public class ExpectedDataModel
{
    [JsonPropertyName("expected_title")]
    public string Title { get; set; }
    
    [JsonPropertyName("expected_nickname")]
    public string NickName { get; set; }
    
    [JsonPropertyName("expected_sender_name")]
    public string SenderName { get; set; }
    
    [JsonPropertyName("expected_message_to_proton")]
    public string Message { get; set; }
}