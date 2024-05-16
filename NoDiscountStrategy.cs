using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAssignment
{
    public class NoDiscountStrategy : IShoppingDiscountStrategy
    {
        public double CalculateShoppingDiscount(double price)
        {
            return 0;
        }
    }
}
