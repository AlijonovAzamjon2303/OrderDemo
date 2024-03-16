using OrderDemo.Services.ShippingServices;

namespace OrderDemo.Models
{
    public interface IOrder
    {
        double GetTotal();
        double GetTotalWeight();
        void SetShippingType(IShipping shipping);
        double GetShippingCost();
        DateTime GetShippingDate();
        void AddItem(Item item);
    }
}
