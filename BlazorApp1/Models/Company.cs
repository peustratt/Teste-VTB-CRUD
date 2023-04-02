using System.Text.Json.Serialization;

namespace BlazorApp1.Models;
public class Company
{
    [JsonPropertyName("_id")]
    public Id Id { get; set; }
    public DateType DateCreated { get; set; }
    public DateType DateModified { get; set; }
    public bool Active { get; set; }
    public string CreatedByUser { get; set; }
    public string ModifiedByUser { get; set; }
    public string Nome { get; set; }
    public string Site { get; set; }
    
    public Id Segmento { get; set; }
    
    [JsonPropertyName("611edbfdfd5915f2ae005dc5")]
    public List<Segmento> Segmentos { get; set; }
}
