namespace ConsoleApp1.CustomExceptions;

[Serializable]
public class InitializationException : Exception
{
    public InitializationException() : base("Unable to initialize a car model from the given entities") { }
}