using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool t = true;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a >= b && a >= c) 
            {
                Console.WriteLine(a + " - самое большое число");
                var s = a > 100 ? "больше 100" : "меньше 100";
                Console.WriteLine(s);
                Console.ReadLine();
                switch(t)
                {
                    case true when  a % 2 == 0:
                        Console.WriteLine(a + " - четное число");
                        Console.ReadLine();
                        break;
                    case true when a % 2 == 1:
                        Console.WriteLine(a + " - нечетное число");
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }

            }
            else if (b > a && b >= c) 
            {
                Console.WriteLine(b + " - самое большое число");
                var s = b > 100 ? "больше 100" : "меньше 100";
                Console.WriteLine(s);
                Console.ReadLine();
                switch(t)
                {
                    case true when b % 2 == 0:
                        Console.WriteLine(b + " - четное число");
                        Console.ReadLine();
                        break;
                    case true when b % 2 == 1:
                        Console.WriteLine(b + " - нечетное число");
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }
            }
            else 
            {
                Console.WriteLine(c + " - самое большое число");
                var s = c > 100 ? "больше 100" : "меньше 100";
                Console.WriteLine(s);
                Console.ReadLine();
                switch(t)
                {
                    case true when c % 2 == 0:
                        Console.WriteLine(c + " - четное число");
                        Console.ReadLine();
                        break;
                    case true when c % 2 == 1:
                        Console.WriteLine(c + " - нечетное число");
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
