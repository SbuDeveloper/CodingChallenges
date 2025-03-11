using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestDome_Maga_Store
{
    public class CalculateDiscountedPrices
    {
        Standard _standard = new Standard();
        Seasonal _seasonal = new Seasonal();
        Weight _weight = new Weight();

        public double GetDiscountedPrice(double cartWeight, double totalPrice, Discount.DiscountType discountType)
        {
            var discount = 0.0;
            if(Convert.ToInt32(discountType) == 0)
            {
                discount = _standard.CalculateStandardDiscount(totalPrice);
            }
            else if (Convert.ToInt32(discountType) == 1)
            {
                discount = _seasonal.CalculateSeasonalDiscount(totalPrice);
            }
            else if (Convert.ToInt32(discountType) == 2)
            {
                discount = _weight.CalculateWeightDiscount(cartWeight, totalPrice);
            }
            return discount;
        }
    }
}