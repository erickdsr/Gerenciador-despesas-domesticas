using HouseholdExpenseManager.Api.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace HouseholdExpenseManager.Api.Data.Context;

/// <summary>
/// Contexto do Entity Framework Core responsavel pelo mapeamento das entidades para o SQLite.
/// </summary>
public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    /// <summary>
    /// Tabela de pessoas cadastradas.
    /// </summary>
    public DbSet<Person> People => Set<Person>();

    /// <summary>
    /// Tabela de transacoes financeiras.
    /// </summary>
    public DbSet<FinancialTransaction> Transactions => Set<FinancialTransaction>();

    /// <summary>
    /// Configura nomes de tabelas, relacionamentos e precisao monetaria.
    /// </summary>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Person>(entity =>
        {
            entity.ToTable("People");

            // Ao excluir uma pessoa, todas as transacoes relacionadas tambem devem ser excluidas.
            entity.HasMany(person => person.Transactions)
                .WithOne(transaction => transaction.Person)
                .HasForeignKey(transaction => transaction.PersonId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<FinancialTransaction>(entity =>
        {
            entity.ToTable("Transactions");

            // Armazena valores monetarios com duas casas decimais para evitar problemas de arredondamento.
            entity.Property(transaction => transaction.Amount)
                .HasPrecision(18, 2);
        });
    }
}
