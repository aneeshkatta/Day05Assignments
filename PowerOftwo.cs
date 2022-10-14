using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOfTWO
{
    class PowerOftwo
    {
        public static void power()
        {
            
            Console.WriteLine("Enter a number to get table till the entered number");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
               Console.WriteLine("{0}*{1}={2} \n",2, Math.Pow(2, i-1), 2* Math.Pow(2, i-1));
            }
        }
    }
}
