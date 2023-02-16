namespace ConsoleApp1;

public class DeviceButton
{
    private ICommand _command;

    public DeviceButton(ICommand command)
    {
        _command = command;
    }

    public void Press()
    {
        _command.Execute();
    }
}