using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int a, b, dob = 1;
            Console.Write("Введите a = ");
            while (!int.TryParse(Console.ReadLine(),out a))
            {
                Console.WriteLine("Ошибка ввода, введите целое число а");
            }
            Console.Write("Введите b = ");
            while (!int.TryParse(Console.ReadLine(),out b))
            {
                Console.WriteLine("Ошибка ввода,введите целое число b");
            }
            if (b > a)
            {

                for (int i = a; i <= b; i++)
                {
                    dob *= i;
                }
                Console.WriteLine(dob);
            }
            else Console.WriteLine("Ошибка, не верно введены исходные данные(a>b),программа завершена");

        }
    }
}
