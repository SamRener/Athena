namespace Athena.Domain;

public record Result
{
    public bool IsSuccess { get; set; }
    public bool IsFailure { get { return Error != null; } }
    public Error? Error { get; set; }
    protected Result() => IsSuccess = true;
    protected Result(Exception exception) => Error = exception;
    protected Result(Error error) => Error = error;

    public static Result Success() => new();
    public static Result Failure(Exception exception) => new(exception);
    public static Result Failure(Error error) => new(error);

    public static implicit operator Result(Exception exception) => Failure(exception);
    public static implicit operator Result(Error error) => Failure(error);
}

public record Result<T> : Result
{
    public T? Value { get; set; }
    public Result(T value) : base()
    {
        Value = value;
    }
    public Result(Error error) : base(error)
    {
    }

    public static Result<T> Success(T value) => new(value);
    public static new Result<T> Failure(Error error) => new(error);

    public static implicit operator Result<T>(T value) => Success(value);
    public static implicit operator T(Result<T> result) => result.Value!;
}

public record Error(string Id, ErrorType Type, string Description)
{
    public static Error NotFound { get { return new("NotFound", ErrorType.NotFound, "Registry Not Found"); } }
    public static implicit operator Error(Exception exception) => new("UnhandledException", ErrorType.Exception, exception.Message);
}

public enum ErrorType { NotFound, Exception }