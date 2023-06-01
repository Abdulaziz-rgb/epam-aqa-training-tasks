using ConsoleApp1.Model;

namespace ConsoleApp1.Commands;

public interface ICar
{
    public void CountTypes();

    public void CountAll();

    public void AveragePrice();

    public void AveragePriceType(string search);
    
}