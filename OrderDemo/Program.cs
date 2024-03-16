using OrderDemo.Models;
using OrderDemo.Services.ShippingServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Order order = new Order();
        Sea sea = new Sea();
        Ground ground = new Ground();
        Air air = new Air();

        do
        {
            PrintMenu();
            Console.Write("Enter choice : ");
            string userChoise = Console.ReadLine();

            switch (userChoise)
            {
                case "1":
                    {
                        order.SetShippingType(ground);
                        Console.WriteLine(order.GetShippingCost());
                        Console.WriteLine();
                    }
                    break;
                case "2":
                    {
                        order.SetShippingType(air);
                        Console.WriteLine(order.GetShippingCost());
                        Console.WriteLine();
                    }
                    break;
                case "3":
                    {
                        order.SetShippingType(sea);
                        Console.WriteLine(order.GetShippingCost());
                        Console.WriteLine();
                    }
                    break;
            }
        } while (true);
    }
    static void PrintMenu()
    {
        Console.WriteLine("1.Air");
        Console.WriteLine("2.Ground");
        Console.WriteLine("3.Sea");
    }
}