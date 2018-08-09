using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 133.33 * 0.9 = 119.997 = 120.00
/// 533.33 * 0.8 = 426.664 = 426.66
/// 534.66 * 0.8 = 427.728 = 427.73
/// 1001 = 1001 - 200 = 801
/// 
/// </summary>
/// 
namespace Vic.CSharp.Week4.Discount.AlexGao
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal inputMoney = 0;

            while (true)
            {
                Console.WriteLine("\n\n Victoria C# Homework Week 3 by Alex Gao");
                Console.WriteLine("\n Hint: ------------------------------");

                Console.WriteLine("\n <100: 90.98 = 90.98");
                Console.WriteLine("\n Negative: -9 = 0");

                Console.WriteLine("\n >= 100 and <500: 133.33 * 0.9 = 119.997 = 120.00");
                Console.WriteLine("\n >=500 and <1000: 533.33 * 0.8 = 426.664 = 426.66");
                Console.WriteLine("\n                  534.66 * 0.8 = 427.728 = 427.73");
                Console.WriteLine("\n >=1000: 1001 = 1001 - 200 = 801");
                Console.WriteLine("\n -----------------------------------");

                Console.WriteLine("\n Please Input the Bill's Amount:");

                string inputString = Console.ReadLine();

                try
                {
                    int i = int.Parse(inputString);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nError!!! input {0} is NOT integer", inputString);
                    Console.ReadKey();
                    continue;
                }

                inputMoney = Convert.ToDecimal(inputString);

                DiscountCalculator discountCalculator = new DiscountCalculator();
                decimal money = discountCalculator.Calculate(inputMoney);
                money = Math.Round(money, 2);

                Console.WriteLine("\n\nThe Bill's Amount(discounted):{0}", money);
                Console.ReadKey();
            }
        }
    }
}
