using HouseholdExpenseManager.Api.DTOs.Person;

namespace HouseholdExpenseManager.Api.Services.Interfaces;

/// <summary>
/// Contrato de regras de negocio para pessoas.
/// </summary>
public interface IPersonService
{
    /// <summary>
    /// Retorna todas as pessoas no formato exposto pela API.
    /// </summary>
    Task<List<PersonResponse>> GetAllAsync();

    /// <summary>
    /// Retorna uma pessoa pelo identificador ou gera erro quando nao existir.
    /// </summary>
    Task<PersonResponse> GetByIdAsync(int id);

    /// <summary>
    /// Valida e cadastra uma nova pessoa.
    /// </summary>
    Task<PersonResponse> CreateAsync(CreatePersonRequest request);

    /// <summary>
    /// Remove uma pessoa existente.
    /// </summary>
    Task DeleteAsync(int id);
}
