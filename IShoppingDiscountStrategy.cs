using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAssignment
{
    public interface IShoppingDiscountStrategy
    {
        double CalculateShoppingDiscount(double price);
    }
}
