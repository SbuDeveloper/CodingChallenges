using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace TestDome_Maga_Store
{
    public class Seasonal : CalculateDiscount
    {
    //     public ICalculateDiscount _calculateDiscount { get; set; }
    //     public Seasonal(ICalculateDiscount calculateDiscount)
    //     {
    //         _calculateDiscount = calculateDiscount;
    //     }
    
        CalculateDiscount _calculateDiscount = new CalculateDiscount();

        public double CalculateSeasonalDiscount(double totalPrice)
        {
            int percentage = 12;
            return _calculateDiscount.CalculateDiscountPrice(percentage, totalPrice);
        }
    }
}