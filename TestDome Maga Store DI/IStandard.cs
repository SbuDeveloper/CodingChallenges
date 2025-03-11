using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestDome_Maga_Store
{
    public interface IStandard
    {
        double CalculateStandardDiscount(double totalPrice);
    }
}