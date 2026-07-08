namespace HouseholdExpenseManager.Api.Exceptions;

/// <summary>
/// Excecao usada quando um recurso solicitado nao existe.
/// </summary>
public class NotFoundException(string message) : Exception(message)
{
}
