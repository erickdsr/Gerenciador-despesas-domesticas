using System.ComponentModel.DataAnnotations;

namespace HouseholdExpenseManager.Api.Models.Entities;

// Represents a person who owns financial transactions.
public class Person
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    public int Age { get; set; }

    public ICollection<FinancialTransaction> Transactions { get; set; } = new List<FinancialTransaction>();
}
