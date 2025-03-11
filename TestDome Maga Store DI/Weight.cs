

namespace TestDome_Maga_Store
{
    public class Weight : CalculateDiscount
    {
        CalculateDiscount _calculateDiscount = new CalculateDiscount();

        public double CalculateWeightDiscount(double weight, double totalPrice)
        {
            int percentage = 0;
            if(weight <= 10)
            {
                percentage = 6;
            }
            else if (weight > 10)
            {
                percentage = 18;
            }

            return _calculateDiscount.CalculateDiscountPrice(percentage, totalPrice);
        }
    }
}