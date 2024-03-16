using OrderDemo.Models;

namespace OrderDemo.Services.ShippingServices
{
    public class Ground : IShipping
    {
        public string Name { get; set; }
        public Ground()
        {
            this.Name = "Ground";
        }
        public double GetCost(Order order)
        {
            if (order.GetTotal() > 100)
            {
                return 0;
            }

            return Math.Max(10, order.GetTotalWeight() * 1.5);
        }

        public DateTime GetDate(Order order)
        {
            return DateTime.Now.AddDays(3);
        }
    }
}
