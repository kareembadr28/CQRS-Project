namespace CQRS_Project.Result
{
   public class Result<T>: Result
    {
        public T? Value { get; }
        private Result(bool isSuccess, T? value, Error? error) : base(isSuccess, error)
        {
            Value = value;
        }
        public static Result<T> Success(T value) => new(true, value, Error.None);
        public static new Result<T> Failure(Error error) => new(false, default, error);
    }
}
