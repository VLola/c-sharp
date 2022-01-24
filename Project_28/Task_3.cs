using System;
using static System.Console;

namespace Project_28
{
    class Task_3
    {
        public void Start()
        {
            WriteLine("Задание 3:");
            WriteLine("Введите А");
            int A = Convert.ToInt32(ReadLine());
            WriteLine("Введите B");
            int B = Convert.ToInt32(ReadLine());
            for (int a = A; a <= B; a++)
            {
                for (int b = 0; b < a; b++)
                {
                    Write(a);
                }
                WriteLine();
            }
        }
    }
}
