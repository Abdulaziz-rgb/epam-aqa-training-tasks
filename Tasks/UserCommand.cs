using ConsoleApp1.Commands;

namespace ConsoleApp1;

public class UserCommand
{
    private Command _command;

    public UserCommand(Command command)
    {
        _command = command;
    }

    public void Press()
    {
        _command.Execute();
    }
}