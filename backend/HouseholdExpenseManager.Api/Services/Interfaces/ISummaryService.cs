using HouseholdExpenseManager.Api.DTOs.Summary;

namespace HouseholdExpenseManager.Api.Services.Interfaces;

public interface ISummaryService
{
    Task<SummaryResponse> GetSummaryAsync();
}
