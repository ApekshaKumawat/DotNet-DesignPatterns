using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAssignment
{
    public class ShoppingMall
    {
        public IShoppingDiscountStrategy DiscountStrategy { get; set; }

        public void setDiscountStrategy(IShoppingDiscountStrategy shoppingDiscountStrategy)
        {
            this.DiscountStrategy = shoppingDiscountStrategy;
        }

        public double CalculateTotalPrice(double price)
        {

            return price - DiscountStrategy.CalculateShoppingDiscount(price);
        }

    }
}
