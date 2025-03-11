using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestDome_Maga_Store
{
    public class CalculateDiscount : ICalculateDiscount
    {
        public double CalculateDiscountPrice(int percentage, double totalPrice)
        {
            var discount = (double)percentage / 100 * totalPrice;
            discount = totalPrice - discount;

            return discount;
        }
    }
}