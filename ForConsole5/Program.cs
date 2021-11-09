using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole5
{
    
    class Program
    {
        static int fakt(int g)
        {
            if (g == 1) return 1;
            return g * fakt(g - 1);
        }
        static void Main(string[] args)
        {
            int n, sum = 0;
            Console.Write("Введите n = ");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Ошибка ввода, введите целое число n");
            }
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                    sum += fakt(i);
                Console.WriteLine(sum);
            }
            else Console.WriteLine("Ошибка,введены не корректные данные(n<0),программа завершена");

        }
    }
}
