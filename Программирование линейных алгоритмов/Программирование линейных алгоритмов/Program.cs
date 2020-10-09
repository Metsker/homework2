﻿using System;
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
                sbyte x1 = sbyte.Parse(Console.ReadLine());
                Console.Write("Введите y1: ");
                sbyte y1 = sbyte.Parse(Console.ReadLine());
                Console.Write("Введите x2: ");
                sbyte x2 = sbyte.Parse(Console.ReadLine());
                Console.Write("Введите y2: ");
                sbyte y2 = sbyte.Parse(Console.ReadLine());
                Console.Write("Введите x3: ");
                sbyte x3 = sbyte.Parse(Console.ReadLine());
                Console.Write("Введите y3: ");
                sbyte y3 = sbyte.Parse(Console.ReadLine());
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