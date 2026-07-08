using HouseholdExpenseManager.Api.DTOs.Summary;

namespace HouseholdExpenseManager.Api.Services.Interfaces;

/// <summary>
/// Contrato para calculo dos resumos financeiros exibidos no dashboard.
/// </summary>
public interface ISummaryService
{
    /// <summary>
    /// Calcula totais por pessoa e totais gerais da casa.
    /// </summary>
    Task<SummaryResponse> GetSummaryAsync();
}
