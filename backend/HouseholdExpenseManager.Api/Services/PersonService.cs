using System.ComponentModel.DataAnnotations;
using HouseholdExpenseManager.Api.DTOs.Person;
using HouseholdExpenseManager.Api.Exceptions;
using HouseholdExpenseManager.Api.Models.Entities;
using HouseholdExpenseManager.Api.Repositories.Interfaces;
using HouseholdExpenseManager.Api.Services.Interfaces;

namespace HouseholdExpenseManager.Api.Services;

/// <summary>
/// Cuida da validacao e da orquestracao de pessoas antes dos dados chegarem ao repositorio.
/// </summary>
public class PersonService(IPersonRepository personRepository) : IPersonService
{
    /// <summary>
    /// Busca todas as pessoas e converte entidades para DTOs de resposta.
    /// </summary>
    public async Task<List<PersonResponse>> GetAllAsync()
    {
        var people = await personRepository.GetAllAsync();

        return people.Select(MapToResponse).ToList();
    }

    /// <summary>
    /// Busca uma pessoa pelo id e dispara erro padronizado quando nao existir.
    /// </summary>
    public async Task<PersonResponse> GetByIdAsync(int id)
    {
        var person = await personRepository.GetByIdAsync(id);

        if (person is null)
        {
            throw new NotFoundException("Person not found.");
        }

        return MapToResponse(person);
    }

    /// <summary>
    /// Valida os dados de entrada, cria a entidade e retorna o registro criado.
    /// </summary>
    public async Task<PersonResponse> CreateAsync(CreatePersonRequest request)
    {
        // Normaliza a entrada do usuario antes de validar e salvar.
        var name = request.Name.Trim();

        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ValidationException("Name is required.");
        }

        if (request.Age < 0)
        {
            throw new ValidationException("Age cannot be negative.");
        }

        var person = new Person
        {
            Name = name,
            Age = request.Age
        };

        var createdPerson = await personRepository.CreateAsync(person);

        return MapToResponse(createdPerson);
    }

    /// <summary>
    /// Remove uma pessoa existente e deixa o EF Core aplicar a exclusao em cascata.
    /// </summary>
    public async Task DeleteAsync(int id)
    {
        var person = await personRepository.GetByIdAsync(id);

        if (person is null)
        {
            throw new NotFoundException("Person not found.");
        }

        // As transacoes relacionadas sao removidas pela configuracao de cascade delete do EF Core.
        await personRepository.DeleteAsync(person);
    }

    /// <summary>
    /// Traduz a entidade de banco para o contrato publico da API.
    /// </summary>
    private static PersonResponse MapToResponse(Person person)
    {
        return new PersonResponse
        {
            Id = person.Id,
            Name = person.Name,
            Age = person.Age
        };
    }
}
