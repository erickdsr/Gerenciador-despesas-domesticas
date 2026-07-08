using HouseholdExpenseManager.Api.Models.Entities;

namespace HouseholdExpenseManager.Api.Repositories.Interfaces;

public interface ITransactionRepository
{
    Task<List<FinancialTransaction>> GetAllAsync();

    Task<FinancialTransaction?> GetByIdAsync(int id);

    Task<FinancialTransaction> CreateAsync(FinancialTransaction transaction);

    Task<List<FinancialTransaction>> GetByPersonIdAsync(int personId);
}
