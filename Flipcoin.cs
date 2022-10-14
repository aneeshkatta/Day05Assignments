using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05assignments
{
    
    class Flipcoin
    {
       
            public static void Flipcoincheck()
            {
                Console.WriteLine("Enter a number of times to toss");
                int num = Convert.ToInt32(Console.ReadLine());
                int heads = 1;
                //int tails = 0;
                int count1 = 0;
                int count2 = 0;
                for (int x = 0; x < num; x++)
                {
                    Random random = new Random();
                    int coinflipresult = random.Next(0, 2);

                    if (coinflipresult == heads)
                    {
                        Console.WriteLine("heads won");
                        count1 += 1;
                    }
                    else
                    {
                        Console.WriteLine("tails won");
                        count2 += 1;
                    }
                }
                if (count1 > count2)
                {
                    Console.WriteLine("heads is winner");

                }
                else
                {
                    Console.WriteLine("tails is winner");
                }

                float result1 = (count1 / num) * 100;
                float result2 = (count2 / num) * 100;
                Console.WriteLine("heads % won " + result1);
                Console.WriteLine("tails % won " + result2);

            }

        }
    }
