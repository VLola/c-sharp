using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_36
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("Enter the number of the task to run");
                Console.WriteLine("Available tasks: 1, 2, 3, 4");
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
                    default:
                        break;
                }
            }
        }
    }
}
