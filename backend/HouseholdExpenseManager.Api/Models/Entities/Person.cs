using System.ComponentModel.DataAnnotations;

namespace HouseholdExpenseManager.Api.Models.Entities;

/// <summary>
/// Entidade de dominio que representa uma pessoa que possui transacoes financeiras.
/// </summary>
public class Person
{
    /// <summary>
    /// Chave primaria gerada automaticamente pelo banco.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Nome obrigatorio da pessoa.
    /// </summary>
    [Required]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Idade usada nas regras de negocio de transacoes.
    /// </summary>
    public int Age { get; set; }

    /// <summary>
    /// Transacoes vinculadas a pessoa; sao excluidas em cascata quando a pessoa e removida.
    /// </summary>
    public ICollection<FinancialTransaction> Transactions { get; set; } = new List<FinancialTransaction>();
}
