using System.ComponentModel.DataAnnotations;
using HouseholdExpenseManager.Api.Models.Enums;

namespace HouseholdExpenseManager.Api.DTOs.Transaction;

/// <summary>
/// Dados enviados pelo cliente para cadastrar uma transacao financeira.
/// </summary>
public class CreateTransactionRequest
{
    /// <summary>
    /// Texto que descreve a origem da renda ou o motivo da despesa.
    /// </summary>
    [Required(ErrorMessage = "Description is required.")]
    [MinLength(1, ErrorMessage = "Description is required.")]
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Valor monetario da transacao; deve ser sempre maior que zero.
    /// </summary>
    [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than zero.")]
    public decimal Amount { get; set; }

    /// <summary>
    /// Tipo da transacao: despesa ou renda.
    /// </summary>
    [Required(ErrorMessage = "Transaction type is required.")]
    public TransactionType? Type { get; set; }

    /// <summary>
    /// Identificador da pessoa responsavel pela transacao.
    /// </summary>
    [Range(1, int.MaxValue, ErrorMessage = "Person is required.")]
    public int PersonId { get; set; }
}
