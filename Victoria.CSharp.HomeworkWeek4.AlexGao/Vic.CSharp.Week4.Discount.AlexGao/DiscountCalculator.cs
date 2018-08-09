using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vic.CSharp.Week4.Discount.AlexGao
{
    public class DiscountCalculator
    {
        public decimal Bill = 0; //Reserver .99    Math.Round(decimal, 2);
        public decimal Nine = 0.9M;
        public decimal Eight = 0.8M;

        //public decimal Money = 101;

        public decimal Calculate(decimal money)
        {
            //money = money * Nine;
            //Console.WriteLine("\n\n------------ and 0.9:\n{0}", Math.Round(money, 2));
            //Console.ReadKey();

            //return 0;

            if (money < 0)
            {
                return 0;
            } else if (money < 100)
                    {
                        return money;
                    }
                   else if (money >= 100 && money < 500)
                        {
                            return money * Nine;
                        }
                        else if (money >= 500 && money < 1000)
                             {
                                return money * Eight;
                             }
                            else if (money >= 1000)
                                 {
                                    return money - 200;
                                 }
                                else return 0;
        }
    }
}
