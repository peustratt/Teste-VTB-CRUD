using BlazorApp1.Models;

namespace BlazorApp1.Services.CompanyService;

public interface ISegmentoService
{
    public List<Segmento>? Segmentos { get; set; }

    public Task GetSegmentos();
}