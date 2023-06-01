using ConsoleApp1.Commands;
using ConsoleApp1.Model;

namespace ConsoleApp1;

public static class Handler
{
    public static void RunProgram()
    {
        GetNumberOfCarAddedToList();
        TakeAndDoCommand();
    }

    private static void GetNumberOfCarAddedToList()
    {
        var carList = CarBase.GetAllCars();
        
        Console.WriteLine("How many car models do you want to add to the existing list ?");
        var total = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < total; i++)
        {
            Console.Write("Enter brand name: "); 
            var brandName = Console.ReadLine();

            Console.Write("Enter model name: ");
            var modelName = Console.ReadLine();

            Console.Write("Enter quantity: ");
            var quantity  = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter price: ");
            var price = Convert.ToInt32(Console.ReadLine());
        
            carList.Add(new CarModel
            {
                Brand = brandName,
                Model = modelName,
                Quantity = quantity,
                Price = price
            });
        }
    }

    private static void TakeAndDoCommand()
    {
        string[] options = { "1", "2", "3", "4", "5" };

        Console.Write("Choose commands with a NUMBER only!\n");

        Console.WriteLine(@"
1.Get the number of car brands...
2.Get the total number of cars...
3.Get the average cost of the cars
4.Get the average cost of the car of your choice...
5.Exit...");

        string choice = Console.ReadLine();

        if (!options.Contains(choice))
        {
            throw new InvalidOperationException("You entered a false value. Please, run the program again!");
        }

        var car = new Car();

        UserCommand onPress;
        switch (choice)
        {
            case "1":
                var command = new GetCountTypes(car);
                onPress = new UserCommand(command);
                onPress.Press();
                break;
            case "2":
                var allCommand = new GetCountAll(car);
                onPress = new UserCommand(allCommand);
                onPress.Press();
                break;
            case "3":
                var priceCommand = new GetAveragePrice(car);
                onPress = new UserCommand(priceCommand);
                onPress.Press();
                break;
            case "4":
                Console.WriteLine("Enter the branch name you want to be checked: ");
                string search = Console.ReadLine();
                var typeCommand = new GetAveragePriceType(car, search);
                onPress = new UserCommand(typeCommand);
                onPress.Press();
                break;
            case "5":
                break;
        }
    }
}
