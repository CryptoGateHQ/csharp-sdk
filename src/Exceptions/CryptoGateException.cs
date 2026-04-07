namespace CryptoGate.Exceptions;

public class CryptoGateException : Exception
{
    public string ErrorCode  { get; }
    public int    HttpStatus { get; }

    public CryptoGateException(string message, string errorCode = "UNKNOWN_ERROR", int httpStatus = 0)
        : base(message)
    {
        ErrorCode  = errorCode;
        HttpStatus = httpStatus;
    }
}

public class AuthenticationException : CryptoGateException
{
    public AuthenticationException(string? message = null)
        : base(message ?? "Invalid or missing API key", "AUTHENTICATION_ERROR", 401) { }
}

public class NotFoundException : CryptoGateException
{
    public NotFoundException(string? message = null)
        : base(message ?? "Resource not found", "NOT_FOUND", 404) { }
}

public class ValidationException : CryptoGateException
{
    public ValidationException(string? message = null, string code = "VALIDATION_ERROR")
        : base(message ?? "Invalid request parameters", code, 400) { }
}

public class RateLimitException : CryptoGateException
{
    public RateLimitException(string? message = null)
        : base(message ?? "Rate limit exceeded", "RATE_LIMIT_EXCEEDED", 429) { }
}
