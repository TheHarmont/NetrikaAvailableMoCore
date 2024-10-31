namespace NAMO.Application.Common;

public class Result<T>
{
    public T? Data { get; }
    public string? ErrorMessage { get; }
    public bool IsSuccess { get; }

    private Result(bool result, T? value, string? error)
    {
        IsSuccess = result;
        Data = value;
        ErrorMessage = error;
    }

    public static Result<T> Success(T value) => new Result<T>(true, value, null);
    public static Result<T> Failure(string? error = null) => new Result<T>(false, default, error);
}
