using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole1
{
    class Program
    {
        static double myK(int n, int k)
        {
            double dob = 1;
                for (int i = n; i <= k; i++)
                {
                    dob *= i;
                }
            
            return dob;
        }
        static void Main(string[] args)
        {
            int a, b;
            double res;
            Console.Write("Введите а = ");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Ошибка ввода, введите целое число a");
            }
            Console.Write("Введите b = ");
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Ошибка ввода, введите целое число b");
            }
            if (a < b)
            {
                res = myK(a, b);
                Console.WriteLine(res);
            }
            else Console.WriteLine("Ошибка,не верно введены исходные данные(A>B),программа завершена");
        }
    }
}
