using BlazorApp1.Models;
using BlazorApp1.Models.Dtos;

namespace BlazorApp1.Services.CompanyService;

public interface ICompanyService
{
   public List<Company> Companies { get; set; }

   public Task GetCompanies();

   public Task<Company> GetCompany(string id);

   public Task CreateCompany(Company company);

   public Task UpdateCompany(string id, Company company);

   public Task<bool> DeleteCompany(string id);
}
