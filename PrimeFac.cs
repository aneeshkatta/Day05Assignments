using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactorization
{
    public class PrimeFac
    {
        public static void Prime()
        {
            Console.WriteLine("Enter a number to get prime factors with Logic -> Traverse till i*i <= N instead of i <= N");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int b = 1; b*b <= a; b++)
            {
                if (a % b == 0)
                {
                    Console.WriteLine(b + " is a factor of " + a);
                }
            }
        }
    }
}
