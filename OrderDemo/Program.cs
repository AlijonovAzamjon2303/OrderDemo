using OrderDemo.Models;
using OrderDemo.Services.ShippingServices;

class Program
{
    static void Main(string[] args)
    {
        Order order = new Order();
        Sea sea = new Sea();
        Ground ground = new Ground();
        Air air = new Air();

        string userChoise;
        do
        {
            PrintMenu();
            Console.Write("Enter choice : ");
            userChoise = Console.ReadLine();

            switch (userChoise)
            {
                case "1":
                    {
                        Console.Clear();
                        order.SetShippingType(ground);
                        Console.WriteLine(order.GetShippingCost());
                        Console.WriteLine();
                    }
                    break;
                case "2":
                    {
                        Console.Clear();
                        order.SetShippingType(air);
                        Console.WriteLine(order.GetShippingCost());
                        Console.WriteLine();
                    }
                    break;
                case "3":
                    {
                        Console.Clear();
                        order.SetShippingType(sea);
                        Console.WriteLine(order.GetShippingCost());
                        Console.WriteLine();
                    }
                    break;
                case "4":
                    {
                        Console.Clear();
                        Item item = new Item();
                        Console.Write("Name "); item.Name = Console.ReadLine();
                        Console.Write("Weight "); item.Weight = Convert.ToDouble(Console.ReadLine());
                        order.AddItem(item);
                    }
                    break;
            }
        } while (userChoise != "5");
    }
    static void PrintMenu()
    {
        Console.WriteLine("1.Air");
        Console.WriteLine("2.Ground");
        Console.WriteLine("3.Sea");
        Console.WriteLine("4.Add Item");
        Console.WriteLine("5.Exit");
    }
}