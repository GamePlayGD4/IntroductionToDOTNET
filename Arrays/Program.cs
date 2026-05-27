#define ARRAYS_1
//#define ARRAYS_2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
#if ARRAYS_1
            int[] arr = { 3, 5, 8, 13, 21 };
            Console.WriteLine(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();

            foreach (int i in arr)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine($"сумма: {sum}");
            Console.WriteLine($"среднее арифметическое: {sum / arr.Length}");
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
            }
            Console.WriteLine($"Минимальное значение: {min}");

            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
            }
            Console.WriteLine($"Максимальное значение: {max}");
#endif
#if ARRAYS_2
            int[,] i_arr_2 =
                {
                { 3, 5, 8},
                {13, 21, 34},
                {55, 89, 144 },
                {233, 377, 610 },
            };
            Console.WriteLine($"Количество измерений: {i_arr_2.Rank}");
            Console.WriteLine($"Length: {i_arr_2.Length}");
            Console.WriteLine($"Rows: {i_arr_2.GetLength(0)}");
            Console.WriteLine($"Cols: {i_arr_2.GetLength(1)}");
            for (int i = 0; i < i_arr_2.GetLength(0); i++)
            {
                for (int j = 0; j < i_arr_2.GetLength(1); j++)
                {
                    Console.Write(i_arr_2[i, j] + "\t");
                }
                Console.WriteLine();
            }
            foreach (int i in i_arr_2)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine(); 
#endif

        }
    }
}
