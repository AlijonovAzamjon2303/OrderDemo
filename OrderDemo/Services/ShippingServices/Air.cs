using OrderDemo.Models;

namespace OrderDemo.Services.ShippingServices
{
    public class Air : IShipping
    {
        public string Name { get; set; }
        public Air()
        {
            this.Name = "Air";
        }
        public double GetCost(Order order)
        {
            if (order.GetTotal() > 200)
            {
                return 0;
            }

            return Math.Max(20, order.GetTotalWeight() * 2);
        }

        public DateTime GetDate(Order order)
        {
            return DateTime.Now.AddDays(1);
        }
    }
}
