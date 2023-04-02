using System.Net.Http.Json;
using BlazorApp1.Models;

namespace BlazorApp1.Services.CompanyService;

public class SegmentoService : ISegmentoService
{
    private readonly string uri =
        "https://nocodebackend-nocodebackend-stage.azurewebsites.net/api/v1/dataset/6429f720cc6d53302309d37f/611edbd7fd5915f2ae005dc2?apiKey=64287679cc6d53302309cb89&pageSize=1000";
    private readonly HttpClient _http;

    public SegmentoService(HttpClient http)
    {
        _http = http;
    }

    public List<Segmento> Segmentos { get; set; } = new List<Segmento>();
    
    public async Task GetSegmentos()
    {
        var data = await _http.GetFromJsonAsync<ApiResponseSegmento>(uri);
        Segmentos = data.Data;
    }
}

public class ApiResponseSegmento
{
    public List<Segmento> Data { get; set; }
}