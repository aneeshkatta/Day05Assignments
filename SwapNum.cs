using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumber
{
    public class SwapNum
    {
        public static void Swapping()
        {
            int a = 20;
            int b = 30;
            Console.WriteLine("Value of a and b before swapping");
            Console.WriteLine("a="  + a);
            Console.WriteLine("b=" + b);
            int tempswap = a;
            a = b;
            b = tempswap;
           Console.WriteLine("Value of a and b after swapping");
            Console.WriteLine("a=" +  a);
            Console.WriteLine("b=" +  b);
         
        }
    }

}
