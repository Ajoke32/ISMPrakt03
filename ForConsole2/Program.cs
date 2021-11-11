using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole2
{
    class Program
    {
        static double myR(int n)
        {
            double d = 0;
            for (int i = 1; i <= n; i++)
                d += 1.0 / i;

            return d;
        }

        static void Main(string[] args)
        {
            double k;
            int n;
            Console.Write("Введите число n = ");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Ошибка ввода, введите целое число n");
            }
            if (n > 0)
            {
                k = myR(n);
                Console.WriteLine(k);
            }
            else Console.WriteLine("Ошибка,число n должно быть больше 0, програма завершена");
        }
    }
}
