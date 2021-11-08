using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны для 1 треугольника");
            double a1 = Convert.ToInt32(Console.ReadLine());
            double b1 = Convert.ToInt32(Console.ReadLine());
            double c1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стороны для 2 треугольника");
            double a2 = Convert.ToInt32(Console.ReadLine());
            double b2 = Convert.ToInt32(Console.ReadLine());
            double c2 = Convert.ToInt32(Console.ReadLine());
            Triangl(ref a1, b1, c1, a2, b2, c2);
            Console.ReadKey();
        }
        static void Triangl(ref double a1, double b1, double c1, double a2, double b2, double c2)
        {
            double p1 = (a1 + b1 + c1)/2;
            double p2 = (a2 + b2 + c2)/ 2;
            double s1 = Math.Sqrt(p1 * (p1 - a1) * (p1 - b1) * (p1 - c1));
            double s2 = Math.Sqrt(p2 * (p2 - a2) * (p2 - b2) * (p2 - c2));
            Console.WriteLine("Площадь 1-го треугольника {0}", s1);
            Console.WriteLine("Площадь 2-го треугольника {0}", s2);
            if (s1 < s2)
            {
                Console.WriteLine("Макс площадь у 2-го треугольника");
            }
            else
            {
                Console.WriteLine("Макс площадь у 1-го треугольника");
            }
        }
    }
}

