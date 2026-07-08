using HouseholdExpenseManager.Api.Models.Entities;

namespace HouseholdExpenseManager.Api.Repositories.Interfaces;

/// <summary>
/// Contrato de acesso a dados para transacoes financeiras.
/// </summary>
public interface ITransactionRepository
{
    /// <summary>
    /// Busca todas as transacoes incluindo os dados da pessoa vinculada.
    /// </summary>
    Task<List<FinancialTransaction>> GetAllAsync();

    /// <summary>
    /// Busca uma transacao pelo identificador.
    /// </summary>
    Task<FinancialTransaction?> GetByIdAsync(int id);

    /// <summary>
    /// Persiste uma nova transacao.
    /// </summary>
    Task<FinancialTransaction> CreateAsync(FinancialTransaction transaction);

    /// <summary>
    /// Busca as transacoes de uma pessoa especifica.
    /// </summary>
    Task<List<FinancialTransaction>> GetByPersonIdAsync(int personId);
}
