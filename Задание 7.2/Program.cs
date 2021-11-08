using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длинну ребра куба");
            int a = Convert.ToInt32(Console.ReadLine());
            Calc(ref a);
            Console.ReadKey();
        }
                static void Calc(ref int a)
        {
            double v = Math.Pow(a, 3);
            double s = 6 * Math.Pow(a, 2);
            Console.WriteLine("Объем куба = {0}",v);
            Console.WriteLine("Площадь поверхности куба = {0}", s);
        }
    }
}