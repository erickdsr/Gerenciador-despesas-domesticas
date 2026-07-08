namespace HouseholdExpenseManager.Api.Exceptions;

/// <summary>
/// Excecao usada quando uma regra de negocio da aplicacao e violada.
/// </summary>
public class BusinessRuleException(string message) : Exception(message)
{
}
