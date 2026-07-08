using HouseholdExpenseManager.Api.DTOs.Transaction;

namespace HouseholdExpenseManager.Api.Services.Interfaces;

/// <summary>
/// Contrato de regras de negocio para transacoes financeiras.
/// </summary>
public interface ITransactionService
{
    /// <summary>
    /// Retorna todas as transacoes no formato exposto pela API.
    /// </summary>
    Task<List<TransactionResponse>> GetAllAsync();

    /// <summary>
    /// Retorna uma transacao pelo identificador ou gera erro quando nao existir.
    /// </summary>
    Task<TransactionResponse> GetByIdAsync(int id);

    /// <summary>
    /// Valida regras de negocio e cadastra uma transacao.
    /// </summary>
    Task<TransactionResponse> CreateAsync(CreateTransactionRequest request);
}
