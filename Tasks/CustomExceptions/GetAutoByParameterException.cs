namespace ConsoleApp1.CustomExceptions;

public class GetAutoByParameterException : Exception
{
    public GetAutoByParameterException() { }

    public GetAutoByParameterException(string message) 
        : base(String.Format($"Property with {message} does not exist!")) { }
    
}