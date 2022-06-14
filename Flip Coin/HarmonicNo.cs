using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flip_Coin
{
    public class HarmonicNo
    {
        public static void CalculateHarmonicNo()
        {
            Console.WriteLine("Enter the value of n");
            int N = Convert.ToInt32(Console.ReadLine());
            double harmonic = 1;
            for (int i = 2; i <= N; i++)
            {
                harmonic += (double)1 / i;
            }
            Console.WriteLine("Sum of Harmonic number is :" + harmonic);
        }
    }
}
