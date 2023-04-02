using System.Text.Json.Serialization;

namespace BlazorApp1.Models.Dtos;

public class CompanyDTO
{
    [JsonPropertyName("Active")]
    public bool Active { get; set; }
    [JsonPropertyName("Nome")]
    public string Nome { get; set; }
    [JsonPropertyName("Site")]
    public string Site { get; set; }
    [JsonPropertyName("Segmento")]
    public Id Segmento { get; set; }
}