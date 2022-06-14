using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flip_Coin
{
    public class power2
    {
        public int num = 0;
        public static void pow2()
        {

            Console.WriteLine("The Power Value of :"); //input from user
            int power = 1;
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i =1; i<= num; i++)
            {
                power = power * 2;
            }
            Console.WriteLine(power);              //Op
           

        }

    }
}
