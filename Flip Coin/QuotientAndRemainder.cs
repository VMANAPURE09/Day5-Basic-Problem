using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flip_Coin
{
    public class QuotientAndRemainder
    {

        public static void CalculateQuotientAndRemainder()
        {
            float dividend;
            float divisor;
            Console.WriteLine("Enter the Dividend value :");
            dividend = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Divisor value :");
            divisor = Convert.ToInt32(Console.ReadLine());

            float quotient = dividend / divisor;
            float remainder = dividend % divisor;


            Console.WriteLine("Quotient : {0}", quotient);
            Console.WriteLine("Remainder : {0}", remainder);
        }
    }
}
