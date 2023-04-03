using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEven
{
    public
        class OddEvenNumber
    {
        static void Main(string[] args)
        {
            int even = 0, odd = 0, positive = 0, negative = 0;
            
            Console.WriteLine("Please Enter minimum number: ");
            int m =int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter maximum number: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = m; i <= n; i++)
            {

                if (i % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }

                if (i > 0)
                {
                    positive++;
                }
                else 
                {
                    negative++;
                }
            }
        

            Console.WriteLine("You have " + even + " even numbers between your min and max values.");
            Console.WriteLine("You have " + odd + " even numbers between your min and max values.");
            Console.WriteLine("You have " + positive + "even numbers between your min and max values.");
        }
    }
}
