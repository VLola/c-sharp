using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_36
{
    public struct Coefficient
    {
        public double A;
        public double B;

    }
    public class Urovnenie
    {
        public double Solution(double X, Coefficient coefficient)
        {
            //Линейное уровнение A * X + B * Y = 0 из него X = (-B * Y) / A
            return (-coefficient.A * X) / coefficient.B;
        }
        public void Answer(double X, string ab)
        {
            Console.WriteLine($"Ответ: Y = {Solution(X, Equation.Parse(ab))}");
        }
    }
    public abstract class Equation
    {
        public static Coefficient Parse(string ab)
        {
            Coefficient coefficient;
            string a = "";
            string b = "";
            bool check = false;
            foreach (char it in ab)
            {
                if (it == ' ' || it == ',') check = true;
                else
                {
                    if (check) a += it;
                    else b += it;
                }
            }
            coefficient.A = Convert.ToDouble(a);
            coefficient.B = Convert.ToDouble(b);
            return coefficient;
        }
    }
    class Task_01
    {
        public void Start()
        {
            Console.WriteLine("Формула линейного уровнения A * X + B * Y = 0");
            string ab;
            double X;
            Console.WriteLine("Введите коэфициенты А и B через пробел или запятую");
            ab = Console.ReadLine();
            Console.WriteLine("Введите X");
            X = Convert.ToDouble(Console.ReadLine());
            Urovnenie urovnenie = new Urovnenie();
            urovnenie.Answer(X, ab);
        }
    }
}
