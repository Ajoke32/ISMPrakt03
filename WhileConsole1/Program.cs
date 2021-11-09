using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileConsole1
{
    class Program
    {
        static int myN(int n,int k)
        {
            return k + n;
        }

        static void Main(string[] args)
        {
            double l=0,k,h=0,b=0;
            int n;
            Console.Write("Введите число n = ");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Ошибка ввода, введите целое число n");
            }
            if (n > 0)
            {
                while (l <= n)
                {
                    b -= b;
                    while (b <= n)
                    {

                        if (l == b + 1)
                            h += Math.Pow(l, n - b);
                        b++;
                    }
                    l++;
                }
                Console.WriteLine(h);
            }
            else Console.WriteLine("Исходные данные введены не верно(n<0),программа завершена");
        }
    }
}
