using System;

namespace Project_34
{
    class Program
    {
        public abstract class Figura
        {
            public double a;
            public double b;
            public double c;
            public double d;
            public double h;
            public double r;
            public double S;
            public double P;
            public double Pi = 3.1415;

            public Figura(double a) { this.a = a; }
            public Figura(double a, double b) { this.a = a; this.b = b; }
            public Figura(double a, double b, double c) { this.a = a; this.b = b; this.c = c; }
            public Figura(double a, double b, double c, double d, double h) { this.a = a; this.b = b; this.c = c; this.d = d; this.h = h; }
            public virtual double Perimetr() { return P; }
            public virtual double Square() { return S; }
        }
        public class Rectangle : Figura
        {
            public Rectangle(double a, double b) : base(a, b) { }
            public override double Perimetr() { P = (a + b) * 2; return P; }
            public override double Square() { S = a * b; return S; }
        }
        public class Triangle : Figura
        {
            public Triangle(double a, double b, double c) : base(a, b, c) { }
            public override double Perimetr() { P = a + b + c; return P; }
            public override double Square() { P = Perimetr(); S = Math.Sqrt(P * (P - a) * (P - b) * (P - c)); return S; }
        }
        public class Quadrate : Figura
        {
            public Quadrate(double a) : base(a) { }
            public override double Perimetr() { P = a * 4; return P; }
            public override double Square() { S = a * a; return S; }
        }
        public class Rhombus : Figura
        {
            public Rhombus(double a, double b) : base(a, b) { h = b; }
            public override double Perimetr() { P = a * 4; return P; }
            public override double Square() { S = a * h; return S; }
        }
        public class Parallelogram : Figura
        {
            public Parallelogram(double a, double b, double c) : base(a, b, c) { h = c; }
            public override double Perimetr() { P = (a + b) * 2; return P; }
            public override double Square() { S = a * h; return S; }
        }
        public class Trapezoid : Figura
        {
            public Trapezoid(double a, double b, double c, double d, double h) : base(a, b, c, d, h) { }
            public override double Perimetr() { P = (a + b + c + d); return P; }
            public override double Square() { P = Perimetr(); S = (a + b) / (a - b) * Math.Sqrt((P - a) * (P - b) * (P - a - c) * (P - a - d)); return S; }
        }
        public class Circle : Figura
        {
            public Circle(double a) : base(a) { r = a; }
            public override double Perimetr() { P = 2 * r * Pi; return P; }
            public override double Square() { S = Pi * r * r; return S; }
        }
        public class Ellipse : Figura
        {
            public Ellipse(double a, double b) : base(a, b) { }
            public override double Perimetr() { P = 2 * Pi * Math.Sqrt((a * 2 + b * 2) / 2); return P; }
            public override double Square() { S = Pi * a * b; return S; }
        }
        class CompaundFigure
        {
            public double Sum = 0;
            public double input()
            {
                return Convert.ToDouble(Console.ReadLine());
            }
            public void Shadow(char shadow)
            {
                switch (shadow)
                {
                    case 'a':
                        Console.WriteLine("Введите a");
                        break;
                    case 'b':
                        Console.WriteLine("Введите b");
                        break;
                    case 'c':
                        Console.WriteLine("Введите c");
                        break;
                    case 'd':
                        Console.WriteLine("Введите d");
                        break;
                    case 'h':
                        Console.WriteLine("Введите h");
                        break;
                    case 'r':
                        Console.WriteLine("Введите r");
                        break;
                    default: break;
                }
            }
            public void Rectangle()
            {
                Shadow('a');
                double a = input();
                Shadow('b');
                double b = input();
                Rectangle figura = new Rectangle(a, b);
                Sum += figura.Square();
            }
            public void Triangle()
            {
                Shadow('a');
                double a = input();
                Shadow('b');
                double b = input();
                Shadow('c');
                double c = input();
                Triangle figura = new Triangle(a, b, c);
                Sum += figura.Square();
            }
            public void Quadrate()
            {
                Shadow('a');
                double a = input();
                Quadrate figura = new Quadrate(a);
                Sum += figura.Square();
            }
            public void Rhombus()
            {
                Shadow('a');
                double a = input();
                Shadow('h');
                double h = input();
                Rhombus figura = new Rhombus(a, h);
                Sum += figura.Square();
            }
            public void Parallelogram()
            {
                Shadow('a');
                double a = input();
                Shadow('b');
                double b = input();
                Shadow('h');
                double h = input();
                Parallelogram figura = new Parallelogram(a, b, h);
                Sum += figura.Square();
            }
            public void Trapezoid()
            {
                Shadow('a');
                double a = input();
                Shadow('b');
                double b = input();
                Shadow('c');
                double c = input();
                Shadow('d');
                double d = input();
                Shadow('h');
                double h = input();
                Trapezoid figura = new Trapezoid(a, b, c, d, h);
                Sum += figura.Square();
            }
            public void Circle()
            {
                Shadow('r');
                double r = input();
                Circle figura = new Circle(r);
                Sum += figura.Square();
            }
            public void Ellipse()
            {
                Shadow('a');
                double a = input();
                Shadow('b');
                double b = input();
                Ellipse figura = new Ellipse(a, b);
                Sum += figura.Square();
            }
            public void SquareFigur()
            {
                for (; ; )
                {
                    Console.WriteLine("Выберите фигуру которую хотите включить в составную фигуру");
                    Console.WriteLine(" 1 - Rectangle,\n 2 - Triangle,\n 3 - Quadrate,\n 4 - Rhombus,\n 5 - Parallelogram,\n 6 - Trapezoid,\n 7 - Circle,\n 8 - Ellipse,\n 0 - Подсчитать площадь составной фигуры");
                    int count = Convert.ToInt32(Console.ReadLine());
                    switch (count)
                    {
                        case 1:
                            Rectangle();
                            break;
                        case 2:
                            Triangle();
                            break;
                        case 3:
                            Quadrate();
                            break;
                        case 4:
                            Rhombus();
                            break;
                        case 5:
                            Parallelogram();
                            break;
                        case 6:
                            Trapezoid();
                            break;
                        case 7:
                            Circle();
                            break;
                        case 8:
                            Ellipse();
                            break;
                        case 0:
                            Console.WriteLine("Площадь составной фигуры - " + Sum);
                            break;
                        default: break;
                    }

                }

            }
        }
        static void Main(string[] args)
        {
            for (; ; )
            {
                CompaundFigure figure = new CompaundFigure();
                figure.SquareFigur();
            }
        }
    }
}
