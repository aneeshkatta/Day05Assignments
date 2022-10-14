using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonicNumber
{
    class HarmonicNumbr
    {
        public static void harmonic()
        {
            Console.WriteLine("Enter a number to get harmonic series till the entered number");
            int a = Convert.ToInt32(Console.ReadLine());
            double b = 0.0;
            for (float i = 1; i <= a; i++)
            {
                Console.WriteLine("1/{0} +", i);
                b = b + (1 / i);
              
            }
            Console.WriteLine("harmonic series sum=" + b);

        }
    }
}
