namespace homework1.Exceptions;

public class InvalidAmountException : Exception
{
    public InvalidAmountException(string message) : base(message) { }
    public InvalidAmountException(string message, Exception innerException) : base(message, innerException) { }
}