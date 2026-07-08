namespace HouseholdExpenseManager.Api.DTOs.Summary;

/// <summary>
/// Totais financeiros consolidados de toda a casa.
/// </summary>
public class GeneralSummaryResponse
{
    /// <summary>
    /// Soma de todas as rendas cadastradas.
    /// </summary>
    public decimal TotalIncome { get; set; }

    /// <summary>
    /// Soma de todas as despesas cadastradas.
    /// </summary>
    public decimal TotalExpenses { get; set; }

    /// <summary>
    /// Saldo liquido geral calculado por renda total menos despesas totais.
    /// </summary>
    public decimal NetBalance { get; set; }
}
