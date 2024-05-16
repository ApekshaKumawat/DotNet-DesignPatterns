using System;


using DesignPatternsAssignment;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            ShoppingMall shoppingMall = new ShoppingMall();

            Console.WriteLine("Hii User, Welcome to the mall!\n Enter your Bill Amount : ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Do you have any card? \n Press 1 for Yes \n Press 2 for No");
            int isCardHolder = Convert.ToInt32(Console.ReadLine());

            if (isCardHolder == 1)
            {
                Console.WriteLine("Which card do you have? \n Press 1 for MemberShipCard \n Press 2 for EmployeeCard");
                int CardChoice = Convert.ToInt32(Console.ReadLine());
                switch (CardChoice)
                {
                    case 1:
                        shoppingMall.setDiscountStrategy(new LowDiscountStrategy());
                        Console.WriteLine("Your final amount to pay is : " + shoppingMall.CalculateTotalPrice(price));
                        break;
                    case 2:
                        shoppingMall.setDiscountStrategy(new HighDiscountStrategy());
                        Console.WriteLine("Your final amount to pay is : " + shoppingMall.CalculateTotalPrice(price));
                        break;
                }
            }
            else
            {
                shoppingMall.setDiscountStrategy(new NoDiscountStrategy());
                Console.WriteLine("Your final amount to pay is : " + shoppingMall.CalculateTotalPrice(price));
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input");
        }catch(Exception ex) 
        { 
            Console.WriteLine(ex.ToString()); 
        }
    }
}