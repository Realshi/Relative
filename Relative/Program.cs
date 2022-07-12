using System;

namespace Relative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a >= b && a >= c)
            {
                Console.WriteLine(a + " - самое большое число");
                var s = a > 100 ? "больше 100" : "меньше 100";
                int division = a % 2;
                Console.WriteLine(s);
                Console.ReadLine();
                switch (division)
                {
                    case 0:
                        Console.WriteLine(a + " - четное число");
                        Console.ReadLine();
                        break;
                    case 1:
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
                int division = b % 2;
                Console.WriteLine(s);
                Console.ReadLine();
                switch (division)
                {
                    case 0:
                        Console.WriteLine(b + " - четное число");
                        Console.ReadLine();
                        break;
                    case 1:
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
                int division = c % 2;
                Console.WriteLine(s);
                Console.ReadLine();
                switch (division)
                {
                    case 0:
                        Console.WriteLine(c + " - четное число");
                        Console.ReadLine();
                        break;
                    case 1:
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
