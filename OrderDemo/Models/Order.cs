using OrderDemo.Services.ShippingServices;

namespace OrderDemo.Models
{
    public class Order : IOrder
    {
        private List<Item> items;
        private IShipping shipping;
        public Order()
        {
            items = new List<Item>();
        }
        public double GetShippingCost()
        {
            return shipping.GetCost(this);
        }

        public DateTime GetShippingDate()
        {
            return shipping.GetDate(this);
        }

        public double GetTotal()
        {
            return items.Count;
        }

        public double GetTotalWeight()
        {
            return (double)items.Sum(x => x.Weight);
        }

        public void SetShippingType(IShipping shipping)
        {
            this.shipping = shipping;
        }
    }
}
