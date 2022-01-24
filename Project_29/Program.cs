using System;
using static System.Console;

namespace Project_29
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                WriteLine("Enter the number of the task to run");
                WriteLine("Available tasks: 1, 2, 3");
                int number = Int32.Parse(ReadLine());
                switch (number)
                {
                    case 1:
                        Task_1 task_1 = new Task_1();
                        task_1.Start();
                        break;
                    case 2:
                        Task_2 task_2 = new Task_2();
                        task_2.Start();
                        break;
                    case 3:
                        Task_3 task_3 = new Task_3();
                        task_3.Start();
                        break;
                    default:
                        break;
                }
            }
        }
    }
    
}
