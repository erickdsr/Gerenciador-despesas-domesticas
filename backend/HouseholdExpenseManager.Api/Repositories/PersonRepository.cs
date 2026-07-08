using HouseholdExpenseManager.Api.Data.Context;
using HouseholdExpenseManager.Api.Models.Entities;
using HouseholdExpenseManager.Api.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HouseholdExpenseManager.Api.Repositories;

/// <summary>
/// Mantem as consultas EF Core de pessoas isoladas das regras de negocio da camada de servico.
/// </summary>
public class PersonRepository(AppDbContext context) : IPersonRepository
{
    /// <summary>
    /// Retorna pessoas ordenadas por id para manter listagem previsivel.
    /// </summary>
    public async Task<List<Person>> GetAllAsync()
    {
        return await context.People
            .OrderBy(person => person.Id)
            .ToListAsync();
    }

    /// <summary>
    /// Retorna uma pessoa especifica ou nulo quando ela nao existir.
    /// </summary>
    public async Task<Person?> GetByIdAsync(int id)
    {
        return await context.People
            .FirstOrDefaultAsync(person => person.Id == id);
    }

    /// <summary>
    /// Adiciona uma pessoa e salva as mudancas no banco.
    /// </summary>
    public async Task<Person> CreateAsync(Person person)
    {
        context.People.Add(person);
        await context.SaveChangesAsync();

        return person;
    }

    /// <summary>
    /// Remove uma pessoa ja carregada pelo servico.
    /// </summary>
    public async Task DeleteAsync(Person person)
    {
        // O cascade delete configurado no AppDbContext tambem remove as transacoes desta pessoa.
        context.People.Remove(person);
        await context.SaveChangesAsync();
    }

    /// <summary>
    /// Verifica existencia sem carregar a entidade completa.
    /// </summary>
    public async Task<bool> ExistsAsync(int id)
    {
        return await context.People
            .AnyAsync(person => person.Id == id);
    }
}
