using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    internal class LeapYr
            {
        public static void YearCheck()
        {
            Console.WriteLine("Enter a year");
            int num = Convert.ToInt32(Console.ReadLine());
            
            if (num%4==0)
            {

                Console.WriteLine("Year is a Leap year " + num );
            }
            else
            {
                Console.WriteLine("Year is not a Leap year " + num);
            }
        }
    }
}
