using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAssignment
{
    public class LowDiscountStrategy : IShoppingDiscountStrategy
    {
        public double CalculateShoppingDiscount(double price)
        {
            return 0.1 * price;
        }
    }
}
