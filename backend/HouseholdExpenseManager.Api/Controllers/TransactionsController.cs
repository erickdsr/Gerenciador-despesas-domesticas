using HouseholdExpenseManager.Api.DTOs.Transaction;
using HouseholdExpenseManager.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HouseholdExpenseManager.Api.Controllers;

[ApiController]
[Route("api/transactions")]
public class TransactionsController(ITransactionService transactionService) : ControllerBase
{
    // Returns all registered transactions.
    [HttpGet]
    public async Task<ActionResult<List<TransactionResponse>>> GetAllAsync()
    {
        var transactions = await transactionService.GetAllAsync();

        return Ok(transactions);
    }

    // Creates a new transaction.
    [HttpPost]
    public async Task<ActionResult<TransactionResponse>> CreateAsync(CreateTransactionRequest request)
    {
        var transaction = await transactionService.CreateAsync(request);

        return CreatedAtAction(nameof(GetAllAsync), new { id = transaction.Id }, transaction);
    }
}
