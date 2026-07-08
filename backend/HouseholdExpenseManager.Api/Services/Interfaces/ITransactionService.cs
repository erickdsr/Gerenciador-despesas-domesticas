using HouseholdExpenseManager.Api.DTOs.Transaction;

namespace HouseholdExpenseManager.Api.Services.Interfaces;

public interface ITransactionService
{
    Task<List<TransactionResponse>> GetAllAsync();

    Task<TransactionResponse> GetByIdAsync(int id);

    Task<TransactionResponse> CreateAsync(CreateTransactionRequest request);
}
