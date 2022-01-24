using System;

namespace Project_33
{
    class Figure
    {
        // Размер фигур
        private const int size = 5;
        // Название фигур
        private const string isSquare = "Square";
        private const string isRhomb = "Rhomb";
        private const string isTrigon = "Trigon";
        private const string isTrapeze = "Trapeze";
        private const string isPolygon = "Polygon";
        // Координаты точек фигур
        private int a { get; set; }
        private int b { get; set; }
        private int i { get; set; }
        private int j { get; set; }
        // Выбор пользователем цвет фигуры
        public void Colors()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Выберите цвет фигуры: {GetType().Name} \n1 - red\n2 - blue\n3 - green\n4 - yellow\n5 - magenta\n");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                default:
                    Console.WriteLine("Ошибка!!!");
                    Colors();
                    break;
            }
        }
        // Размер сторон фигур
        public void Size()
        {
            switch (GetType().Name)
            {
                case isSquare:
                    a = 1 * size;
                    b = 3 * size;
                    break;
                case isRhomb:
                    a = 2 * size;
                    b = 2 * size;
                    break;
                case isTrigon:
                    a = 1 * size;
                    b = 2 * size;
                    break;
                case isTrapeze:
                    a = 1 * size;
                    b = 3 * size;
                    break;
                case isPolygon:
                    a = 2 * size;
                    b = 3 * size;
                    break;
                default:
                    break;
            }
        }
        // Условия рисования фигур
        public bool Check()
        {
            switch (GetType().Name)
            {
                case isSquare:
                    if (i == 0 || i == a - 1 || j == 0 || j == b - 1) return true;
                    else return false;
                case isRhomb:
                    if (i + j == a / 2 - 1 || i + j == a / 2 + a - 1 || i == j - a / 2 || i == j - a / 2 + a) return true;
                    else return false;
                case isTrigon:
                    if (i + a == j || i + j == a - 1 || i == a - 1) return true;
                    else return false;
                case isTrapeze:
                    if (i + a == j - a || i + j == a - 1 || i == a - 1 || i == 0 && j > b / 3 - 1 && j < b - b / 3) return true;
                    else return false;
                case isPolygon:
                    if (i + a == j || i + j == a / 2 - 1 || i == 0 && j > b / 3 - 1 && j < b - b / 3 || i == a - 1 && j > b / 3 - 1 && j < b - b / 3 || i + j == a * 2 - 1 || i == j + a / 2) return true;
                    else return false;
                default:
                    return false;
            }
        }
        // Функция вывода фигуры в консоль
        public void Print()
        {
            Size();
            Colors();
            for (i = 0; i < a; i++)
            {
                for (j = 0; j < b; j++)
                {
                    if (Check()) Console.Write("#");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        // Функция вывода всех фигур в консоль
        public void FullPrint()
        {
            new Square().Print();
            new Rhomb().Print();
            new Trigon().Print();
            new Trapeze().Print();
            new Polygon().Print();
        }
        // Классы фигур
        public class Square : Figure { }
        public class Rhomb : Figure { }
        public class Trigon : Figure { }
        public class Trapeze : Figure { }
        public class Polygon : Figure { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Figure Full = new Figure();
            Full.FullPrint();
        }
    }
}
