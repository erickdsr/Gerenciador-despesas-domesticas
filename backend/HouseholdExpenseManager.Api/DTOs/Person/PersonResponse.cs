namespace HouseholdExpenseManager.Api.DTOs.Person;

/// <summary>
/// Representa uma pessoa retornada pela API.
/// </summary>
public class PersonResponse
{
    /// <summary>
    /// Identificador unico gerado pelo banco de dados.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Nome cadastrado para a pessoa.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Idade cadastrada para a pessoa.
    /// </summary>
    public int Age { get; set; }
}
