using OrderDemo.Models;

namespace OrderDemo.Services.ShippingServices
{
    public interface IShipping
    {
        public string Name { get; set; }
        public double GetCost(Order order);
        public DateTime GetDate(Order order);
    }
}
