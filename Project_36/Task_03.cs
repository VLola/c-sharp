using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_36
{
    public class Complex
    {
        public double x;
        public double y;
        public Complex()
        {
            x = 0;
            y = 0;
        }
        public Complex(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public static Complex operator -(Complex z1, Complex z2)
        {
            Complex z3 = new Complex();
            z3.x = z1.x - z2.x;
            z3.y = z1.y - z2.y;
            return z3;
        }
        public static Complex operator -(Complex z2, double a)
        {
            Complex z3 = new Complex();
            z3.x = z2.x - a;
            z3.y = z2.y - a;
            return z3;
        }
        public static Complex operator *(Complex z1, Complex z2)
        {
            Complex z3 = new Complex();
            z3.x = z1.x * z2.x - z1.y * z2.y;
            z3.y = z1.y * z2.x + z1.x * z2.y;
            return z3;
        }
        public static Complex operator *(double a, Complex z2)
        {
            Complex z3 = new Complex();
            z3.x = a * z2.x;
            z3.y = a * z2.y;
            return z3;
        }
        public static Complex operator /(Complex z1, Complex z2)
        {
            Complex z3 = new Complex();
            z3.x = (z1.x * z2.x + z1.y * z2.y) / (z2.x * z2.x + z2.y * z2.y);
            z3.y = (z1.y * z2.x - z1.x * z2.y) / (z2.x * z2.x + z2.y * z2.y);
            return z3;
        }
        public override string ToString() { return $"{x} + {y} * i\n"; }

    }
    class Task_03
    {
        public void Start()
        {
            Complex z = new Complex(1, 1);
            Complex z1;
            z1 = z - (z * z * z - 1) / (3 * z * z);
            Console.WriteLine("z1 = {0}", z1);
        }
    }
}
