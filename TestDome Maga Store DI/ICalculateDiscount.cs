using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace TestDome_Maga_Store
{
    public interface ICalculateDiscount
    {
        double CalculateDiscountPrice(int percentage, double totalPrice);
    }
}