using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    class Program
    {

        static void Main(string[] args)
        {
            double n = Math.Sqrt(1.0 / 2), a = 1;
            int b = 0, c = 0, p = 0, m = 0;
            Console.WriteLine("Франсуа Виет");
            Console.WriteLine("2/Pi примерно = 0.63662");
            while (b < 5)
            {
                b++;
                a *= n;
                n = Math.Sqrt(1.0 / 2 + 1.0 / 2 * n);
                Console.WriteLine(a);
            }
            Console.WriteLine("\n");
            double i = 1, g = 3, k = 1, d,j=2;
            Console.WriteLine("Джон Уоллис");
            Console.WriteLine("2/Pi примерно = 0.63662");
            while (c<5)
            { 
              
                d = k * g / (j * j);
                k += 2 ; g += 2; j += 2;
                i *= d;
                Console.WriteLine(i);
                c++;


            }
            Console.WriteLine("\n");
            Console.WriteLine("Лорд Брунер");
            Console.WriteLine("4/Pi примерно = 1,27324");
            double kk,bb,b2=3,c2=5;
            while (m < 5)
            {
                m++;
                bb = 2 + b2 * b2 / (c2 * c2);
                kk = 1 + 1 / (2 + b2 * b2 / (c2 * c2));
                b2 += 2; c2 += 2;
                Console.WriteLine(kk);
               
            }
            Console.WriteLine("\n");
            double a1=1, b1=3, g1=1;
            Console.WriteLine("Г.Лейбниц");
            Console.WriteLine("Pi/4 = 45 градусов,примерно = 0,785398");
            while (p<5)
            {
                p++;
                if (p%2!=0)
                g1-=a1 / b1;
                if (p % 2 == 0)
                    g1 += a1 / b1;
                b1 += 2;
                Console.WriteLine("g={0}",g1);
                

            }
            Console.WriteLine("Сравнивши результаты формул,с разным количеством итераций, я получил более точный результат с помощью формулы Виета");
        }
    }
}
