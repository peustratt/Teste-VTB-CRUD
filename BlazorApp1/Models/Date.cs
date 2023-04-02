using System.Text.Json.Serialization;

namespace BlazorApp1.Models;

public class DateType
{
    [JsonPropertyName("$date")]
    public DateTime Date { get; set; }
}