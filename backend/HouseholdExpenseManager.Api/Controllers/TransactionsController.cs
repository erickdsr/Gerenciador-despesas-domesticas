using HouseholdExpenseManager.Api.Common;
using HouseholdExpenseManager.Api.DTOs.Transaction;
using HouseholdExpenseManager.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HouseholdExpenseManager.Api.Controllers;

[ApiController]
[Route("api/transactions")]
public class TransactionsController(ITransactionService transactionService) : ControllerBase
{
    /// <summary>
    /// Returns all registered transactions including the person's name.
    /// </summary>
    [HttpGet]
    [ProducesResponseType(typeof(List<TransactionResponse>), StatusCodes.Status200OK)]
    public async Task<ActionResult<List<TransactionResponse>>> GetAllAsync()
    {
        var transactions = await transactionService.GetAllAsync();

        return Ok(transactions);
    }

    /// <summary>
    /// Creates a transaction for an existing person.
    /// </summary>
    [HttpPost]
    [ProducesResponseType(typeof(TransactionResponse), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status404NotFound)]
    public async Task<ActionResult<TransactionResponse>> CreateAsync(CreateTransactionRequest request)
    {
        var transaction = await transactionService.CreateAsync(request);

        return CreatedAtAction(nameof(GetAllAsync), new { id = transaction.Id }, transaction);
    }
}
