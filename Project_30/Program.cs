using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_30
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("Enter the number of the task to run");
                Console.WriteLine("Available tasks: 1, 2, 3, 4, 5, 6, 7");
                int number = Int32.Parse(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        Task_01 task_01 = new Task_01();
                        task_01.Start();
                        break;
                    case 2:
                        Task_02 task_02 = new Task_02();
                        task_02.Start();
                        break;
                    case 3:
                        Task_03 task_03 = new Task_03();
                        task_03.Start();
                        break;
                    case 4:
                        Task_04 task_04 = new Task_04();
                        task_04.Start();
                        break;
                    case 5:
                        Task_05 task_05 = new Task_05();
                        task_05.Start();
                        break;
                    case 6:
                        Task_06 task_06 = new Task_06();
                        task_06.Start();
                        break;
                    case 7:
                        Task_07 task_07 = new Task_07();
                        task_07.Start();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
