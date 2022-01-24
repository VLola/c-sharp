using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_36
{
    public class SystemUrovnenie
    {
        public void Print(double A1, double B1, double A2, double B2)
        {
            int a = 0;
            double Y = 0;
            double X = 0;
            for (double x = -100; x < 100; x += 1)
            {
                if (Urovnenie(A1, B1, x) == Urovnenie(A2, B2, x))
                {
                    Y = Urovnenie(A1, B1, x);
                    X = x;
                    a++;
                }
            }
            if (a == 0) Console.WriteLine("Система не имеет решения\n");
            else if (a == 1) Console.WriteLine($"Решение системы X = {X}, Y = {Y}\n");
            else if (a > 1) Console.WriteLine("Система неопределенная (имеет бесконечное множество решений)\n");
        }
        public double Urovnenie(double A, double B, double X)
        {
            return -A * X / B;
        }
    }
    class Task_02
    {
        public void Start()
        {
            Console.WriteLine("Система уровнений:");
            Console.WriteLine("A1 × X + B1 × Y = 0");
            Console.WriteLine("A2 × X + B2 × Y = 0\n");
            Console.WriteLine("Пример: A1 = 1, B1 = 2, A2 = 2, B2 = 1");
            SystemUrovnenie a = new SystemUrovnenie();
            a.Print(1, 2, 2, 1);

            Console.WriteLine("Пример: A1 = 1, B1 = 1, A2 = 1, B2 = 1");
            a.Print(1, 1, 1, 1);

            double A1;
            double B1;
            double A2;
            double B2;
            Console.WriteLine("Введите А1");
            A1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите B1");
            B1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите А2");
            A2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите B2");
            B2 = Convert.ToDouble(Console.ReadLine());
            a.Print(A1, B1, A2, B2);
        }
    }
}
