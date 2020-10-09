using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazvetAlg
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Высокий уровень #28
                Console.Write("Введите x1: ");
                int x1 = int.Parse(Console.ReadLine());
                Console.Write("Введите y1: ");
                int y1 = int.Parse(Console.ReadLine());
                Console.Write("Введите x2: ");
                int x2 = int.Parse(Console.ReadLine());
                Console.Write("Введите y2: ");
                int y2 = int.Parse(Console.ReadLine());
                Console.Write("Введите x3: ");
                int x3 = int.Parse(Console.ReadLine());
                Console.Write("Введите y3: ");
                int y3 = int.Parse(Console.ReadLine());
                double a = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
                double b = Math.Sqrt((x3 - x1) * (x3 - x1) + (y3 - y1) * (y3 - y1));
                double c = Math.Sqrt((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3));
                double p = (a + b + c) / 2;
                double S = Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 1);
                Console.Write("Площадь S = ");
                Console.WriteLine(S);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
