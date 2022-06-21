using System;
using System.Threading;

namespace Project_55
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Task 1\nCreate a console application that spawns\nflow.This thread should display numbers in the console\nfrom 0 to 50.\n Task 2\nAdd a transfer option to the first task\nstart and end of a range of numbers.Borders defines\nuser.\n Task 3\nAdd to the first task the ability to define\ncustom number of threads.Range restrictions\nthe numbers are also user - selectable.");
            Console.WriteLine("\nMain thread Id - " + Thread.CurrentThread.ManagedThreadId);
            while(true)
            {
                Console.WriteLine("Select Task: 1, 2, 3, 0 - exit");

                int number_task = Convert.ToInt32(Console.ReadLine());

                if (number_task == 1 || number_task == 2 || number_task == 3) NemberTask(number_task);
                else if (number_task == 0) break;
            }
            
        }
        private static void Task1()
        {
            Console.WriteLine("Thread Id - " + Thread.CurrentThread.ManagedThreadId);
            for(int i = 0; i <= 50; i++) Console.Write(i + " ");
        }
        private static void Task2(int i, int count)
        {
            Console.WriteLine("Thread Id - " + Thread.CurrentThread.ManagedThreadId);
            for (; i <= count; i++) Console.Write(i + " ");
        }
        private static void Task3(int start, int end, int threads)
        {
            for (int j = 0; j < threads; j++)
            {
                Thread thread = new Thread(() => Task2(start, end));
                thread.Start();
                thread.Join();
                Console.WriteLine();
            }
        }
        private static void NemberTask(int number)
        {
            Thread thread;
            int start;
            int end;
            switch (number)
            {
                case 1:
                    Console.WriteLine("Task 1");
                    thread = new Thread(Task1);
                    thread.Start();
                    thread.Join();
                    break;
                case 2:
                    Console.WriteLine("Choose start value");
                    start = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Choose end value");
                    end = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Task 2");
                    thread = new Thread(() => Task2(start, end));
                    thread.Start();
                    thread.Join();
                    break;
                case 3:
                    Console.WriteLine("Choose start value");
                    start = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Choose end value");
                    end = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Choose count threads");
                    int threads = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Task 3");
                    Task3(start, end, threads);
                    break;
                default:
                    break;
            }
        }
    }
}
