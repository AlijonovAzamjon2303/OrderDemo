using OrderDemo.Models;

namespace OrderDemo.Services.ShippingServices
{
    public class Sea : IShipping
    {
        public string Name { get; set; }

        public Sea()
        {
            this.Name = "Sea";
        }
        public double GetCost(Order order)
        {
            if (order.GetTotal() > 150)
            {
                return 0;
            }

            return Math.Max(15, order.GetTotalWeight() * 1.75);
        }

        public DateTime GetDate(Order order)
        {
            return DateTime.Now.AddDays(5);
        }
    }
}
