using System.ComponentModel.DataAnnotations;

namespace HouseholdExpenseManager.Api.DTOs.Person;

/// <summary>
/// Dados enviados pelo cliente para cadastrar uma nova pessoa.
/// </summary>
public class CreatePersonRequest
{
    /// <summary>
    /// Nome da pessoa que sera exibido nas listagens e vinculado as transacoes.
    /// </summary>
    [Required(ErrorMessage = "Name is required.")]
    [MinLength(1, ErrorMessage = "Name is required.")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Idade usada para aplicar regras de negocio, como bloquear receitas para menores.
    /// </summary>
    [Range(0, int.MaxValue, ErrorMessage = "Age cannot be negative.")]
    public int Age { get; set; }
}
