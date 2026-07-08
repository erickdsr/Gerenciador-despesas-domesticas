using HouseholdExpenseManager.Api.Data.Context;
using HouseholdExpenseManager.Api.Models.Entities;
using HouseholdExpenseManager.Api.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HouseholdExpenseManager.Api.Repositories;

/// <summary>
/// Centraliza consultas de transacoes e carrega Person quando a UI precisa do nome da pessoa.
/// </summary>
public class TransactionRepository(AppDbContext context) : ITransactionRepository
{
    /// <summary>
    /// Retorna transacoes recentes primeiro e inclui a pessoa vinculada.
    /// </summary>
    public async Task<List<FinancialTransaction>> GetAllAsync()
    {
        return await context.Transactions
            .Include(transaction => transaction.Person)
            .OrderByDescending(transaction => transaction.CreatedAt)
            .ToListAsync();
    }

    /// <summary>
    /// Busca uma transacao especifica incluindo a pessoa vinculada.
    /// </summary>
    public async Task<FinancialTransaction?> GetByIdAsync(int id)
    {
        return await context.Transactions
            .Include(transaction => transaction.Person)
            .FirstOrDefaultAsync(transaction => transaction.Id == id);
    }

    /// <summary>
    /// Adiciona uma transacao e salva as mudancas no banco.
    /// </summary>
    public async Task<FinancialTransaction> CreateAsync(FinancialTransaction transaction)
    {
        context.Transactions.Add(transaction);
        await context.SaveChangesAsync();

        return transaction;
    }

    /// <summary>
    /// Retorna as transacoes de uma pessoa, usadas no calculo dos resumos.
    /// </summary>
    public async Task<List<FinancialTransaction>> GetByPersonIdAsync(int personId)
    {
        return await context.Transactions
            .Include(transaction => transaction.Person)
            .Where(transaction => transaction.PersonId == personId)
            .OrderByDescending(transaction => transaction.CreatedAt)
            .ToListAsync();
    }
}
