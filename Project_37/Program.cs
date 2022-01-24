using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_37
{
    interface Parametrs
    {
        void Colors();
        void Size();
    }
    interface Function : Parametrs
    {
        void Print();
        void FullPrint();
    }
    class Figure : Function
    {
        public class Parametr
        {
            // Размер фигур
            public int size { get; set; }
            // Цвет фигуры
            public ConsoleColor color { get; set; }
            public List<string> list = new List<string>();
        }
        public Parametr parametr = new Parametr();
        public List<Parametr> FullList = new List<Parametr>();


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
            Console.WriteLine($"Выберите цвет фигуры: {GetType().Name} \n1 - red\n2 - blue\n3 - green\n4 - yellow\n5 - magenta\n");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    parametr.color = ConsoleColor.Red;
                    break;
                case 2:
                    parametr.color = ConsoleColor.Blue;
                    break;
                case 3:
                    parametr.color = ConsoleColor.Green;
                    break;
                case 4:
                    parametr.color = ConsoleColor.Yellow;
                    break;
                case 5:
                    parametr.color = ConsoleColor.Magenta;
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
            Console.WriteLine($"Выберите размер фигуры: {GetType().Name} \nОт 3 до 20");
            parametr.size = Convert.ToInt32(Console.ReadLine());
            switch (GetType().Name)
            {
                case isSquare:
                    a = 1 * parametr.size;
                    b = 3 * parametr.size;
                    break;
                case isRhomb:
                    a = 2 * parametr.size;
                    b = 2 * parametr.size;
                    break;
                case isTrigon:
                    a = 1 * parametr.size;
                    b = 2 * parametr.size;
                    break;
                case isTrapeze:
                    a = 1 * parametr.size;
                    b = 3 * parametr.size;
                    break;
                case isPolygon:
                    a = 2 * parametr.size;
                    b = 3 * parametr.size;
                    break;
                default:
                    break;
            }
        }
        // Условия рисования фигур
        public virtual bool Check()
        {
            return false;
        }
        // Функция вывода всех фигур в консоль
        public void FullPrint()
        {
            // Запись всех параметров фигур в List
            FullList.Add(new Square().parametr);
            FullList.Add(new Rhomb().parametr);
            FullList.Add(new Trigon().parametr);
            FullList.Add(new Trapeze().parametr);
            FullList.Add(new Polygon().parametr);
            // Чтение через цыкл
            foreach (var it in FullList)
            {
                Console.ForegroundColor = it.color;
                foreach (var ir in it.list)
                {
                    Console.WriteLine(ir);
                }
                Console.ForegroundColor = ConsoleColor.White;

            }
        }
        // Функция вывода фигуры в консоль через форич
        public void Print()
        {
            Console.ForegroundColor = parametr.color;
            foreach (var it in parametr.list)
            {
                Console.WriteLine(it);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        // Запись фигуры в List через конструктор
        public class Constructor : Figure
        {
            public Constructor()
            {
                Size();
                Colors();
                for (i = 0; i < a; i++)
                {
                    string new_string = "";
                    for (j = 0; j < b; j++)
                    {
                        if (Check()) new_string += "#";
                        else new_string += " ";
                    }
                    parametr.list.Add(new_string);
                }
            }
        }
        // Классы фигур
        public class Square : Constructor
        {
            public override bool Check()
            {
                if (i == 0 || i == a - 1 || j == 0 || j == b - 1) return true;
                else return false;
            }
        }
        public class Rhomb : Constructor
        {
            public override bool Check()
            {
                if (i + j == a / 2 - 1 || i + j == a / 2 + a - 1 || i == j - a / 2 || i == j - a / 2 + a) return true;
                else return false;
            }
        }
        public class Trigon : Constructor
        {
            public override bool Check()
            {
                if (i + a == j || i + j == a - 1 || i == a - 1) return true;
                else return false;
            }
        }
        public class Trapeze : Constructor
        {
            public override bool Check()
            {
                if (i + a == j - a || i + j == a - 1 || i == a - 1 || i == 0 && j > b / 3 - 1 && j < b - b / 3) return true;
                else return false;
            }
        }
        public class Polygon : Constructor
        {
            public override bool Check()
            {
                if (i + a == j || i + j == a / 2 - 1 || i == 0 && j > b / 3 - 1 && j < b - b / 3 || i == a - 1 && j > b / 3 - 1 && j < b - b / 3 || i + j == a * 2 - 1 || i == j + a / 2) return true;
                else return false;
            }
        }
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
