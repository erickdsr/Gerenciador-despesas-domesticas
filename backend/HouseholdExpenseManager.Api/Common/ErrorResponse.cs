namespace HouseholdExpenseManager.Api.Common;

/// <summary>
/// Formato padrao de erro retornado pela API para o frontend.
/// </summary>
public class ErrorResponse
{
    /// <summary>
    /// Indica se a operacao foi concluida com sucesso; em erros sempre sera falso.
    /// </summary>
    public bool Success { get; set; }

    /// <summary>
    /// Mensagem amigavel que explica a falha.
    /// </summary>
    public string Message { get; set; } = string.Empty;
}
