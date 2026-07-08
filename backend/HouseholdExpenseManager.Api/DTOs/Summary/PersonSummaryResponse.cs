namespace HouseholdExpenseManager.Api.DTOs.Summary;

/// <summary>
/// Totais financeiros calculados para uma pessoa especifica.
/// </summary>
public class PersonSummaryResponse
{
    /// <summary>
    /// Identificador da pessoa resumida.
    /// </summary>
    public int PersonId { get; set; }

    /// <summary>
    /// Nome da pessoa resumida.
    /// </summary>
    public string PersonName { get; set; } = string.Empty;

    /// <summary>
    /// Soma de todas as transacoes do tipo renda da pessoa.
    /// </summary>
    public decimal TotalIncome { get; set; }

    /// <summary>
    /// Soma de todas as transacoes do tipo despesa da pessoa.
    /// </summary>
    public decimal TotalExpenses { get; set; }

    /// <summary>
    /// Saldo individual calculado por renda menos despesas.
    /// </summary>
    public decimal Balance { get; set; }
}
