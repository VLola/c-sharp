using System;
using System.Linq;
using static System.Console;

namespace Project_28
{
    class Task_4
    {
        public void Start()
        {
            WriteLine("Задание 4:");
            WriteLine("Введите число");
            int N = Convert.ToInt32(ReadLine());
            WriteLine("Перевернутое число:");
            WriteLine(N.ToString().Reverse().ToArray());
        }
    }
}
