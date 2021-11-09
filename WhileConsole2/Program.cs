using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,k=0;
            Console.Write("Введите n = ");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Ошибка ввода,введите целое число n");
            }
            if (n > 1)
            {
                while (true)
                {

                    if (n < Math.Pow(3, k))
                    {
                        Console.Write("Наименьшее К:");
                        Console.WriteLine(k);
                        break;
                    }
                    k++;
                }
            }
            else Console.WriteLine("Ошибка, исходные данные введено не корректно(n<1),программа завершена");
        }
    }
}
