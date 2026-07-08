using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HouseholdExpenseManager.Api.Models.Enums;

namespace HouseholdExpenseManager.Api.Models.Entities;

/// <summary>
/// Entidade de dominio que representa uma renda ou despesa registrada para uma pessoa.
/// </summary>
public class FinancialTransaction
{
    /// <summary>
    /// Chave primaria gerada automaticamente pelo banco.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Descricao obrigatoria da movimentacao financeira.
    /// </summary>
    [Required]
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Valor monetario positivo da transacao.
    /// </summary>
    public decimal Amount { get; set; }

    /// <summary>
    /// Tipo financeiro da transacao.
    /// </summary>
    public TransactionType Type { get; set; }

    /// <summary>
    /// Chave estrangeira da pessoa responsavel pela transacao.
    /// </summary>
    public int PersonId { get; set; }

    /// <summary>
    /// Navegacao EF Core para a pessoa vinculada.
    /// </summary>
    [ForeignKey(nameof(PersonId))]
    public Person Person { get; set; } = null!;

    /// <summary>
    /// Momento de criacao da transacao em UTC.
    /// </summary>
    public DateTime CreatedAt { get; set; }
}
