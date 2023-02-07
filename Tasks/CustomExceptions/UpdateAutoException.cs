namespace ConsoleApp1.CustomExceptions;

[Serializable]
public class UpdateAutoException : Exception
{
    public UpdateAutoException() { }

    public UpdateAutoException(Guid id) 
        : base(String.Format($"Auto with id {id} cannot be updated!")) { }
}