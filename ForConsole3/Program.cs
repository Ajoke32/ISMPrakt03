using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,dob=0,k=0,j;
            int n;
            Console.Write("Введите степень n = ");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Ошибка ввода, введите целое число n");
            }
            Console.Write("Введите a = ");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Ошибка ввода, введите число a");
            }
            j = a;
            if (n > 0)
            {
                for (int i = 1; i < n; i++)
                {
                    a *= j;
                }

                Console.WriteLine(a);
            }
            else Console.WriteLine("Не верно введены данные,число n должно быть больше 0,програма завершена");
        }
    }
}
