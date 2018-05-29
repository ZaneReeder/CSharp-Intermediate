namespace Section6
{
    //defines capabilities
    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }

    //ShippingCalculator implements interface
    public class ShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
            {
                return order.TotalPrice * 0.1f;
            }

            return 0;
        }
    }
}

