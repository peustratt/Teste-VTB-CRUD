using System.Text.Json.Serialization;

namespace BlazorApp1.Models;
public class Id
{
    [JsonPropertyName("$oid")]
    public string oid { get; set; }
}