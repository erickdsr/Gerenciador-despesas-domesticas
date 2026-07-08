using HouseholdExpenseManager.Api.DTOs.Person;

namespace HouseholdExpenseManager.Api.Services.Interfaces;

public interface IPersonService
{
    Task<List<PersonResponse>> GetAllAsync();

    Task<PersonResponse> GetByIdAsync(int id);

    Task<PersonResponse> CreateAsync(CreatePersonRequest request);

    Task DeleteAsync(int id);
}
