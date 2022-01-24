using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_36
{
    public class Fraction
    {
        public int x;
        public int y;
        public Fraction(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            Fraction f3 = new Fraction(0, 0);
            if (f1.y == f2.y)
            {
                f3.x = f1.x + f2.x;
                f3.y = f1.y;
                return f3;
            }
            else
            {
                int CD = f1.y * f2.y;
                f3.y = CD;
                f3.x = CD / f1.y * f1.x + CD / f2.y * f2.x;
                return f3;
            }
        }
        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            Fraction f3 = new Fraction(0, 0);
            if (f1.y == f2.y)
            {
                f3.x = f1.x - f2.x;
                f3.y = f1.y;
                return f3;
            }
            else
            {
                int CD = f1.y * f2.y;
                f3.y = CD;
                f3.x = CD / f1.y * f1.x - CD / f2.y * f2.x;
                return f3;
            }
        }
        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            Fraction f3 = new Fraction(0, 0);
            f3.x = f1.x * f2.x;
            f3.y = f1.y * f2.y;
            return f3;
        }
        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            Fraction f3 = new Fraction(0, 0);
            f3.x = f2.y;
            f3.y = f2.x;
            return f1 * f3;
        }
        public static bool operator ==(Fraction f1, Fraction f2)
        {
            return f1.x.Equals(f2.x) && f1.y.Equals(f2.y);
        }
        public static bool operator !=(Fraction f1, Fraction f2)
        {
            return !(f1 == f2);
        }
        public static bool operator >(Fraction f1, Fraction f2)
        {
            int x1 = f1.x;
            int x2 = f2.x;
            int y1 = f1.y;
            int y2 = f2.y;
            int CD = y1 * y2;
            int xy1 = CD / y1 * x1;
            int xy2 = CD / y2 * x2;
            return xy1 > xy2;
        }
        public static bool operator <(Fraction f1, Fraction f2)
        {
            int x1 = f1.x;
            int x2 = f2.x;
            int y1 = f1.y;
            int y2 = f2.y;
            int CD = y1 * y2;
            int xy1 = CD / y1 * x1;
            int xy2 = CD / y2 * x2;
            return xy1 < xy2;
        }
        public static bool operator true(Fraction f)
        {
            return f.x < f.y ? false : true;
        }
        public static bool operator false(Fraction f)
        {
            return f.x > f.y ? false : true;
        }
    }
    class Task_04
    {
        public void Start()
        {
            void Print(Fraction f1)
            {
                Console.WriteLine($"{f1.x} / {f1.y}");
            }
            void Check(Fraction f)
            {
                if (f)
                {
                    Console.WriteLine("Неправильная дробь");
                }
                else
                {

                    Console.WriteLine("Правильная дробь");
                }
            }
            Fraction a = new Fraction(1, 2);
            Fraction b = new Fraction(3, 2);
            Console.WriteLine("a =  " + a.x + " / " + a.y);
            Console.WriteLine("b =  " + b.x + " / " + b.y);
            Console.Write("a + b = ");
            Print(a + b);
            Console.Write("a - b = ");
            Print(a - b);
            Console.Write("a * b = ");
            Print(a * b);
            Console.Write("a / b = ");
            Print(a / b);
            bool c = a == b;
            Console.WriteLine("a == b - " + c);
            c = a != b;
            Console.WriteLine("a != b - " + c);
            c = a > b;
            Console.WriteLine("a > b - " + c);
            c = a < b;
            Console.WriteLine("a < b - " + c);
            Console.Write("a - ");
            Check(a);
            Console.Write("b - ");
            Check(b);
        }
    }
}
