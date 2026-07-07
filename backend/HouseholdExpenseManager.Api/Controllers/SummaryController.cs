using HouseholdExpenseManager.Api.DTOs.Summary;
using HouseholdExpenseManager.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HouseholdExpenseManager.Api.Controllers;

[ApiController]
[Route("api/summary")]
public class SummaryController(ISummaryService summaryService) : ControllerBase
{
    // Returns the financial summary grouped by person and the general totals.
    [HttpGet]
    public async Task<ActionResult<SummaryResponse>> GetSummaryAsync()
    {
        var summary = await summaryService.GetSummaryAsync();

        return Ok(summary);
    }
}
