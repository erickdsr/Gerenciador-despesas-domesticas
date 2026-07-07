using HouseholdExpenseManager.Api.DTOs.Summary;
using HouseholdExpenseManager.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HouseholdExpenseManager.Api.Controllers;

[ApiController]
[Route("api/summary")]
public class SummaryController(ISummaryService summaryService) : ControllerBase
{
    /// <summary>
    /// Returns financial totals grouped by person and the general household balance.
    /// </summary>
    [HttpGet]
    [ProducesResponseType(typeof(SummaryResponse), StatusCodes.Status200OK)]
    public async Task<ActionResult<SummaryResponse>> GetSummaryAsync()
    {
        var summary = await summaryService.GetSummaryAsync();

        return Ok(summary);
    }
}
