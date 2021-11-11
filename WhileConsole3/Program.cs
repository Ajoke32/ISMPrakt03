using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            double P,b=10,g=0,n=0;
            Console.Write("Введите P = ");
            P = int.Parse(Console.ReadLine());
            while (true)
            {
                g++;
                b += (b * P) / 100;
                if (b <= 200) n++;
                if (b > 200)
                {
                    n++;
                    break;
                }
            }
            Console.WriteLine("Количество дней:{0}\nСумарный пробег S:{1}",n,b);
            



        }
    }
}
