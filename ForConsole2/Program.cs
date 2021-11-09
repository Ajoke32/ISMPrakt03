using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n,k = 0;
            Console.Write("Введите число n = ");
            while (!double.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Ошибка ввода, введите число n");
            }
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                    k += 1.0 / i;
                Console.WriteLine(k);
            }
            else Console.WriteLine("Ошибка,число n должно быть больше 0, програма завершена");
        }
    }
}
