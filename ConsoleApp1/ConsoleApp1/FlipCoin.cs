using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicfunctionalprograms
{
    public class FlipCoin
    {
        public static void Flipcoinpercentage()
        {
            Console.WriteLine("Enter the value for No. of Flip Coins");

            int count = 1;
            int HeadCount = 0;
            int TailCount = 0;

            double HeadPercentage;
            double TailPercentage;

            int Flip = Convert.ToInt32(Console.ReadLine());

            if (Flip > 0)
            {
                for (int i = 1; i <= Flip; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);
                    Console.WriteLine(number);

                    switch (number)
                    {
                        case 0:
                            TailCount++;
                            break;
                        case 1:
                            HeadCount++;
                            break;
                    }


                }
                Console.WriteLine("--------------");
                HeadPercentage = (HeadCount * 100) / Flip;
                TailPercentage = (TailCount * 100) / Flip;

                Console.WriteLine("Head Percentage : " + HeadPercentage);
                Console.WriteLine("Tail Percentage : " + TailPercentage);

            }
            else
            {
                Console.WriteLine("Enter Positive Integer");
            }
        }



    }

}
