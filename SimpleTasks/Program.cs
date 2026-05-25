//#define FACTORIAL
//#define POWER
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SimpleTasks
{
    class Program
    {
        static void Main(string[] args)
        {

#if FACTORIAL
            Console.WriteLine("Введите число для вычисления факториала: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            Console.WriteLine(result); 
#endif

#if POWER
            Console.WriteLine("Введите число для возведения в степень: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите степень: ");
            int power = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Math.Pow(num, power)); 
#endif

#if FACTORIAL
            ////Console.WriteLine("Введите лимит ряда фибоначи: ");
            ////int limit = Convert.ToInt32(Console.ReadLine());
            ////int result = 0;

            ////for (int i = 0; i <= limit; i++)
            ////{
            ////    if (limit <= 0)
            ////    {
            ////        Console.WriteLine(0);
            ////        break;
            ////    }

            ////    if (i == 0)
            ////    {
            ////        Console.WriteLine(0);
            ////        Console.WriteLine(1);
            ////        continue;
            ////    }
            ////    result = result + i - 1;
            ////    if (result <= limit)Console.WriteLine(result);

            Console.WriteLine("число для факториала: ");
            int n = Convert.ToInt32(Console.ReadLine());
            BigInteger f = 1;
            for (int i = 1; i <= n; i++)
            {
                f *= i;
                Console.WriteLine($"{i}! = {f}");
            }

        } 
#endif

            Console.WriteLine("Введите количество членов ряда фибоначи: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (BigInteger i = 0, a = 0, b = 1, c = a + b; i++ < n; c = (a = b) + (b = c))
                Console.Write(a + (i % 10 == 0 ? "\n" : "\t"));
            Console.WriteLine();
        }
    }
}

