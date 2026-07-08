using HouseholdExpenseManager.Api.Models.Enums;

namespace HouseholdExpenseManager.Api.DTOs.Transaction;

/// <summary>
/// Representa uma transacao financeira retornada pela API.
/// </summary>
public class TransactionResponse
{
    /// <summary>
    /// Identificador unico da transacao.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Descricao informada no cadastro da transacao.
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Valor monetario da transacao.
    /// </summary>
    public decimal Amount { get; set; }

    /// <summary>
    /// Indica se o valor e uma renda ou uma despesa.
    /// </summary>
    public TransactionType Type { get; set; }

    /// <summary>
    /// Identificador da pessoa vinculada.
    /// </summary>
    public int PersonId { get; set; }

    /// <summary>
    /// Nome da pessoa vinculada para evitar uma segunda consulta no frontend.
    /// </summary>
    public string PersonName { get; set; } = string.Empty;

    /// <summary>
    /// Data em UTC em que a transacao foi criada.
    /// </summary>
    public DateTime CreatedAt { get; set; }
}
