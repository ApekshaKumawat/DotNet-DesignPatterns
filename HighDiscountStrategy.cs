using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAssignment
{
    internal class HighDiscountStrategy : IShoppingDiscountStrategy
    {
        public double CalculateShoppingDiscount(double price)
        {
            return 0.2 * price;
        }
    }
}
