using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestDome_Maga_Store
{
    public interface ISeasonal
    {
        double CalculateSeasonalDiscount(double totalPrice);    
    }
}