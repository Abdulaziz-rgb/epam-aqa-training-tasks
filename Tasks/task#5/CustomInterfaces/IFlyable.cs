namespace ConsoleApp1.task_5.CustomInterfaces;

using Models;

public interface IFlyable
{
    public Coordinate CurrentPosition { get; set; }
    public void FlyTo();
    public void GetFlyTime();
}

// I did not understand the task very well. I tried to complete the task as far as I afford
// I hope that the reader understands me :)