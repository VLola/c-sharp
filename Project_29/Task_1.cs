using System;
using System.Linq;
using static System.Console;

namespace Project_29
{
    class Task_1
    {
        public void Start()
        {
            double sum_A = 0;
            double sum_B = 0;
            double mul_AB = 1;
            // Обьявляем массивы
            int[] A;
            double[,] B;
            // Выделяем память
            A = new int[5];
            B = new double[4, 3];
            // Заполняем массивы
            for (int i = 0; i < A.GetLength(0); i++)
            {
                WriteLine("Введите число");
                A[i] = Convert.ToInt32(ReadLine());
            }
            Random rnd = new Random();
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = Convert.ToDouble(rnd.Next(100) / 10.0);
                }
            }
            // Выводим массивы на экран
            WriteLine("Одномерный массив А");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (i % 2 == 0) sum_A += Convert.ToDouble(A[i]);
                mul_AB *= Convert.ToDouble(A[i]);
                Write(A[i] + "\t");
            }

            WriteLine("\nДвумерный массив B");
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (j % 2 != 0) sum_B += B[i, j];
                    mul_AB *= B[i, j];
                    Write(B[i, j] + "\t");
                }
                WriteLine();
            }

            WriteLine("Максимальный элемент массива А = " + A.Max());
            WriteLine("Максимальный элемент массива B = " + B.Cast<double>().Max());

            if (B.Cast<double>().Max() == A.Max()) WriteLine("Общий максимальный элемент в массивах = " + A.Max());
            else WriteLine("Общего максимального элемента в массивах нет");

            WriteLine("Минимальный элемент массива А = " + A.Min());
            WriteLine("Минимальный элемент массива B = " + B.Cast<double>().Min());

            if (B.Cast<double>().Min() == A.Min()) WriteLine("Общий минимальный элемент в массивах = " + A.Min());
            else WriteLine("Общего минимального элемента в массивах нет");

            WriteLine("Общая сумма всех элементов массивов = " + (Convert.ToDouble(A.Sum()) + B.Cast<double>().Sum()));
            WriteLine("Общее произведение всех элементов массивов = " + mul_AB);
            WriteLine("Cумма четных элементов массива А = " + sum_A);
            WriteLine("Cумма нечетных столбцов массива В = " + sum_B);
        }
    }
}
