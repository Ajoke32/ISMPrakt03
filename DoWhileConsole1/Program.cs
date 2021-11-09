using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,suma=0;
            Console.Write("Введите числа, для завершения ввода нажмите 0\n");
            do
            {
                while (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Ошибка ввода, введите целое число n");
                }
                suma += n;
            } while (n != 0);
            Console.WriteLine("Программа завершена\nСума чисел = {0}",suma);
        }
    }
}
