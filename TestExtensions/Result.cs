namespace TestExtensions
{
    public class Result
    {
        public bool IsEqual { get; }
        public string Message { get; }

        private Result(bool isEqual, string message)
        {
            IsEqual = isEqual;
            Message = message;
        }

        internal static Result CreateEqual()
        {
            return new(true, string.Empty);
        }

        internal static Result CreateNotEqual(string message)
        {
            return new(false, message);
        }
    }
}
