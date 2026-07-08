namespace HouseholdExpenseManager.Api.Models.Enums;

/// <summary>
/// Classifica uma transacao como despesa ou renda.
/// </summary>
public enum TransactionType
{
    /// <summary>
    /// Saida de dinheiro.
    /// </summary>
    Expense,

    /// <summary>
    /// Entrada de dinheiro.
    /// </summary>
    Income
}
