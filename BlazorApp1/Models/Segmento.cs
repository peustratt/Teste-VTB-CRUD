using System.Text.Json.Serialization;

namespace BlazorApp1.Models;

public class Segmento
{
    [JsonPropertyName("_id")]
    public Id Id { get; set; }
    public DateType DateCreated { get; set; }
    public DateType DateModified { get; set; }
    public bool Active { get; set; }
    public string CreatedByUser { get; set; }
    public string ModifiedByUser { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
}
