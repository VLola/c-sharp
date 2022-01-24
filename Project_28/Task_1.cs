using static System.Console;

namespace Project_28
{
    class Task_1
    {
        public void Start()
        {
            WriteLine("Задание 1:");
            WriteLine("Введите А сторону прямоугольника");
            int A = int.Parse(ReadLine());
            WriteLine("Введите B сторону прямоугольника");
            int B = int.Parse(ReadLine());
            WriteLine("Введите сторону квадрата");
            int C = int.Parse(ReadLine());

            if (C > A || C > B) WriteLine("Квадрат нельзя разместить в прямоугольнике");
            else
            {
                int a = A / C;
                int b = B / C;
                int c = a * b;
                int d = A - a * C;
                int e = B - b * C;
                int f = d * e;
                WriteLine("Количество квадратов в прямоугольнике: " + c);
                WriteLine("Площадь не занятой части прямоугольника: " + f);
            }
        }
    }
}
