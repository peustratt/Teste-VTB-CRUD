using System.Net.Http.Json;
using BlazorApp1.Models;
using BlazorApp1.Models.Dtos;
using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Services.CompanyService;

public class CompanyService : ICompanyService
{
    private readonly string uri =
        "https://nocodebackend-nocodebackend-stage.azurewebsites.net/api/v1/dataset/6429f720cc6d53302309d37f/611ed902fd5915f2ae005dbb";

    private readonly string apiKey = "apiKey=64287679cc6d53302309cb89";
    private readonly HttpClient _http;
    private readonly NavigationManager _navigationManager;

    public CompanyService(HttpClient http, NavigationManager navigationManager)
    {
        _http = http;
        _navigationManager = navigationManager;
    }

    public List<Company> Companies { get; set; } = new List<Company>();

    public async Task GetCompanies()
    {
        var data = await _http.GetFromJsonAsync<ApiResponseCompany>($"{uri}?{apiKey}");
        Console.WriteLine();
        Companies = data.Data;
    }

    public async Task<Company> GetCompany(string id)
    {
        var company = await _http.GetFromJsonAsync<Company>($"{uri}/{id}?{apiKey}");
        return company;
    }

    public async Task CreateCompany(Company company)
    {
        var companyDTO = new CompanyDTO
        {
            Nome = company.Nome,
            Active = company.Active,
            Segmento = company.Segmento,
            Site = company.Site
        };

        var response = await _http.PostAsJsonAsync($"{uri}?{apiKey}", companyDTO);
        if (response.IsSuccessStatusCode)
        {
            _navigationManager.NavigateTo("/");
        }
    }

    public async Task UpdateCompany(string id, Company company)
    {
        var companyDTO = new CompanyDTO
        {
            Nome = company.Nome,
            Active = company.Active,
            Segmento = company.Segmento,
            Site = company.Site
        };

        var response = await _http.PutAsJsonAsync($"{uri}/{id}?{apiKey}",companyDTO);
        if (response.IsSuccessStatusCode)
        {
            _navigationManager.NavigateTo("/");
        }
    }

    public async Task<bool> DeleteCompany(string id)
    {
        var response =
            await _http.DeleteAsync($"{uri}/{id}?{apiKey}");

        if (response.IsSuccessStatusCode)
        {
            var deletedCompany = Companies.FirstOrDefault(c => c.Id.oid == id);
            if (deletedCompany != null)
            {
                Companies.Remove(deletedCompany);
            }

            return true;
        }

        return false;
    }
}

public class ApiResponseCompany
{
    public List<Company> Data { get; set; }
}