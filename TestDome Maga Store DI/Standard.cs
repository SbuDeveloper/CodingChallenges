using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestDome_Maga_Store
{
    public class Standard : CalculateDiscount
    {
        CalculateDiscount _calculateDiscount = new CalculateDiscount();

        public double CalculateStandardDiscount(double totalPrice)
        {
            int percentage = 6;
            return _calculateDiscount.CalculateDiscountPrice(percentage, totalPrice);

        }
    }
}