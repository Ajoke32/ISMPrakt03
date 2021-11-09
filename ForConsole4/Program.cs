using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double sum = 0;
            Console.Write("Введите a = ");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Ошибка ввода, введите целое число а");
            }
            Console.Write("Введите b = ");
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Ошибка ввода,введите целое число b");
            }
            if (a < b)
            {
                for (int i = a; i <= b; i++)
                    sum += Math.Pow(i, 2);

                Console.WriteLine(sum);
            }
            else Console.WriteLine("Не верно введены данные(a>b),программа завершена");

        }
    }
}
