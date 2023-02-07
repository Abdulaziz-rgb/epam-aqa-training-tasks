namespace ConsoleApp1.CustomExceptions;

[Serializable]
public class RemoveAutoException : Exception
{
    public RemoveAutoException() { }

    public RemoveAutoException(Guid id ) 
        : base(String.Format($"Auto with id {id} cannot be removed!")) { }
}