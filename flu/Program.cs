using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flu
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите целое число a");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число a");
            }
        }
    }
}
