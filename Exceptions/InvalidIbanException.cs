namespace homework1.Exceptions;

public class InvalidIbanException : Exception
{
    public InvalidIbanException(string message) : base(message) { }
    public InvalidIbanException(string message, Exception innerException) : base(message, innerException) { }
}