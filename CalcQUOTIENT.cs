using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputeQuotientRem
{
    internal class CalcQUOTIENT
    {
        public static void quotient()
        {
            Console.WriteLine("Enter a dividend");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a divisor");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quotient is"+num / num1);
            Console.WriteLine("Remainder is"+num % num1);
        }
    }
}
