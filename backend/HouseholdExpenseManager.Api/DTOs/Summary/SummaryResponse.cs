namespace HouseholdExpenseManager.Api.DTOs.Summary;

/// <summary>
/// Resumo financeiro completo exibido no dashboard.
/// </summary>
public class SummaryResponse
{
    /// <summary>
    /// Totais calculados separadamente para cada pessoa cadastrada.
    /// </summary>
    public List<PersonSummaryResponse> People { get; set; } = new List<PersonSummaryResponse>();

    /// <summary>
    /// Totais consolidados considerando todas as pessoas e transacoes.
    /// </summary>
    public GeneralSummaryResponse General { get; set; } = new GeneralSummaryResponse();
}
