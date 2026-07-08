using HouseholdExpenseManager.Api.Models.Entities;

namespace HouseholdExpenseManager.Api.Repositories.Interfaces;

/// <summary>
/// Contrato de acesso a dados para pessoas.
/// </summary>
public interface IPersonRepository
{
    /// <summary>
    /// Busca todas as pessoas cadastradas.
    /// </summary>
    Task<List<Person>> GetAllAsync();

    /// <summary>
    /// Busca uma pessoa pelo identificador.
    /// </summary>
    Task<Person?> GetByIdAsync(int id);

    /// <summary>
    /// Persiste uma nova pessoa.
    /// </summary>
    Task<Person> CreateAsync(Person person);

    /// <summary>
    /// Remove uma pessoa existente.
    /// </summary>
    Task DeleteAsync(Person person);

    /// <summary>
    /// Verifica se existe pessoa com o identificador informado.
    /// </summary>
    Task<bool> ExistsAsync(int id);
}
