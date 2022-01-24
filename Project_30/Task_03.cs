using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_30
{
    class Student
    {
        public string FirstName;
        public string LastName;
        public string Patronymic;
        public string Group;
        public int Age;
        public int[][] Grades = new int[3][];
        public int Lesson;

        public Student()
        {
            Console.WriteLine("Введите имя студента:");
            FirstName = Console.ReadLine();
            Console.WriteLine("Введите фамилию студента:");
            LastName = Console.ReadLine();
            Console.WriteLine("Введите отчество студента:");
            Patronymic = Console.ReadLine();
            Console.WriteLine("Введите группу студента:");
            Group = Console.ReadLine();
            Console.WriteLine("Введите возвраст студента:");
            Age = Convert.ToInt32(Console.ReadLine());
            Grades[0] = new int[0];
            Grades[1] = new int[0];
            Grades[2] = new int[0];
            Lesson = 0;
        }

        public void printText(int N)
        {
            switch (N)
            {
                case 0:
                    Console.WriteLine("0 - окончить ввод оценок");
                    break;
                case 1:
                    Console.WriteLine("Введите оценку:");
                    break;
                case 2:
                    Console.WriteLine("Выберите предмет: 1 - Программированние, 2 - Администратирование, 3 - Дизайн.");
                    break;
                case 3:
                    Console.WriteLine("Программированние:");
                    break;
                case 4:
                    Console.WriteLine("Администратирование:");
                    break;
                case 5:
                    Console.WriteLine("Дизайн:");
                    break;
                case 6:
                    Console.WriteLine("Оценки студента:");
                    break;
                default:
                    break;
            }
        }
        public void setLesson()
        {
            printText(2);
            Lesson = Convert.ToInt32(Console.ReadLine()) - 1;
        }
        public void setGrades()
        {
            setLesson();
            printText(0);
            for (; ; )
            {
                printText(1);
                int grade = Convert.ToInt32(Console.ReadLine());
                if (grade == 0) break;
                int length = Convert.ToInt32(Grades[Lesson].Length);
                Array.Resize(ref Grades[Lesson], length + 1);
                Grades[Lesson][length] = grade;
            }
        }
        public void getGrades()
        {
            setLesson();
            printText(6);
            foreach (int i in Grades[Lesson]) Console.Write(i + "\t");

        }
        public void FullInfo()
        {
            Console.WriteLine($"Имя студента {FirstName}");
            Console.WriteLine($"Фамилия студента {LastName}");
            Console.WriteLine($"Отчество студента {Patronymic}");
            Console.WriteLine($"Возраст студента {Age}");
            printText(6);
            for (int j = 0; j < 3; j++)
            {
                printText(j + 3);
                foreach (int i in Grades[j]) Console.Write(i + "\t");
                Console.WriteLine();
            }
        }
        public void averageScore()
        {
            int Sum = 0;
            setLesson();
            foreach (int i in Grades[Lesson]) Sum += i;
            double aver = Convert.ToDouble(Sum) / Convert.ToDouble(Grades[Lesson].Length);
            Console.WriteLine("Средний балл студента: " + aver);
        }
    }
    class Task_03
    {
        public void Start()
        {
            Student valik = new Student();

            for (; ; )
            {
                Console.WriteLine("\n 1 - Выставить оценки,\n 2 - Посмотреть оценки,\n 3 - Средний балл,\n 4 - Распечатка данных по студенту");
                Console.WriteLine("Выберите действие");
                int action = Convert.ToInt32(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        valik.setGrades();
                        break;
                    case 2:
                        valik.getGrades();
                        break;
                    case 3:
                        valik.averageScore();
                        break;
                    case 4:
                        valik.FullInfo();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
