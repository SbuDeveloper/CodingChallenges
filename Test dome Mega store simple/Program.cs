internal class Program
{
    public enum DiscountType
    {
        Standard,
        Seasonal,
        Weight
    }    
    
    public static void Main(string[] args)
    {
        Console.WriteLine(GetDiscountedPrice(12, 100, DiscountType.Weight));
    }

    public static double GetDiscountedPrice(double cartWeight, 
                                            double totalPrice, 
                                            DiscountType discountType)
    {
        var discount = 0.0;
            if(Convert.ToInt32(discountType) == 0)
            {
                discount = CalculateStandardDiscount(totalPrice);
            }
            else if (Convert.ToInt32(discountType) == 1)
            {
                discount = CalculateSeasonalDiscount(totalPrice);
            }
            else if (Convert.ToInt32(discountType) == 2)
            {
                discount = CalculateWeightDiscount(cartWeight, totalPrice);
            }
            return discount;
    }

    public static double CalculateDiscountedPrice(int percentage, double totalPrice)
        {
            var discount = (double)percentage / 100 * totalPrice;
            discount = totalPrice - discount;

            return discount;
        }

    public static double CalculateStandardDiscount(double totalPrice)
        {
            int percentage = 6;
            return CalculateDiscountedPrice(percentage, totalPrice);

        }

    public static double CalculateSeasonalDiscount(double totalPrice)
        {
            int percentage = 12;
            return CalculateDiscountedPrice(percentage, totalPrice);
        }

     public static double CalculateWeightDiscount(double weight, double totalPrice)
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

            return CalculateDiscountedPrice(percentage, totalPrice);
        }
}