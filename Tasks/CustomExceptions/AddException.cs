namespace ConsoleApp1.CustomExceptions;

public class AddException : Exception
{
    public AddException() { }
    public AddException(Guid id) : base($"Auto with {id} already exists") { }
}