using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_35
{
    class Program
    {
        public struct Product
        {
            public string Name;
            public string Type;
            public int Сount;
        }
        public abstract class Distributor
        {
            public List<Product> came = new List<Product>();
            public List<Product> implemented = new List<Product>();
            public List<Product> writtenOff = new List<Product>();
            public List<Product> transferred = new List<Product>();
            public Product product;
            public enum Тип_товара { Бытовая_химия, Продукты_питания, Зоотовары, Школа }
            public enum Бытовая_химия { Стиральный_порошок, Для_мытья_посуды, Мыло, Шампунь }
            public enum Продукты_питания { Картошка, Морковка, Гречневая_каша, Напиток }
            public enum Зоотовары { Еда_для_собак, Еда_для_кошек, Еда_для_рыб, Еда_для_птиц }
            public enum Школа { Ручка, Пенал, Карандаши, Тетради }

            public int inputInt() { return Convert.ToInt32(Console.ReadLine()); }
            public virtual void AddProduct()
            {
                product = new Product();
                AddType();
                AddName();
                Console.WriteLine("Введите количество товара");
                product.Сount = inputInt();
            }
            public static void PrintGoods(Enum e)
            {
                foreach (var it in Enum.GetValues(e.GetType()))
                    Console.WriteLine($"{it.GetHashCode()} - {it}");
            }
            public void CheckTypes()
            {
                Console.WriteLine("Выберите товар:");
                switch (product.Type)
                {
                    case "Бытовая_химия":
                        PrintGoods(default(Бытовая_химия));
                        break;
                    case "Продукты_питания":
                        PrintGoods(default(Продукты_питания));
                        break;
                    case "Зоотовары":
                        PrintGoods(default(Зоотовары));
                        break;
                    case "Школа":
                        PrintGoods(default(Школа));
                        break;
                    default:
                        break;
                }
            }
            public void AddType()
            {
                Console.WriteLine("Выберите тип товара:");
                PrintGoods(default(Тип_товара));
                product.Type = ((Тип_товара)Enum.GetValues(typeof(Тип_товара)).GetValue(inputInt())).ToString();
            }
            public void AddName()
            {
                switch (product.Type)
                {
                    case "Бытовая_химия":
                        CheckTypes();
                        product.Name = ((Бытовая_химия)Enum.GetValues(typeof(Бытовая_химия)).GetValue(inputInt())).ToString();
                        break;
                    case "Продукты_питания":
                        CheckTypes();
                        product.Name = ((Продукты_питания)Enum.GetValues(typeof(Продукты_питания)).GetValue(inputInt())).ToString();
                        break;
                    case "Зоотовары":
                        CheckTypes();
                        product.Name = ((Зоотовары)Enum.GetValues(typeof(Зоотовары)).GetValue(inputInt())).ToString();
                        break;
                    case "Школа":
                        CheckTypes();
                        product.Name = ((Школа)Enum.GetValues(typeof(Школа)).GetValue(inputInt())).ToString();
                        break;
                    default: break;
                }
            }

            public virtual void PrintList()
            {
                Console.WriteLine($"{product.Type} {product.Name} {product.Сount}");
            }
        }

        public class Came : Distributor
        {
            public void Add()
            {
                AddProduct();
                came.Add(product);
            }
            public override void PrintList()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nСписок товара:");
                foreach (var it in came)
                    Console.WriteLine($"Тип товара - {it.Type}, Название товара - {it.Name}, Количество товара - {it.Сount}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public class Implemented : Distributor
        {
            public void Add()
            {
                AddProduct();
                implemented.Add(product);
            }
            public override void PrintList()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nСписок товара:");
                foreach (var it in implemented)
                    Console.WriteLine($"Тип товара - {it.Type}, Название товара - {it.Name}, Количество товара - {it.Сount}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public class WrittenOff : Distributor
        {
            public void Add()
            {
                AddProduct();
                writtenOff.Add(product);
            }
            public override void PrintList()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nСписок товара:");
                foreach (var it in writtenOff)
                    Console.WriteLine($"Тип товара - {it.Type}, Название товара - {it.Name}, Количество товара - {it.Сount}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public class Transferred : Distributor
        {
            public void Add()
            {
                AddProduct();
                transferred.Add(product);
            }
            public override void PrintList()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nСписок товара:");
                foreach (var it in transferred)
                    Console.WriteLine($"Тип товара - {it.Type}, Название товара - {it.Name}, Количество товара - {it.Сount}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        static void Main(string[] args)
        {
            int input() { return Convert.ToInt32(Console.ReadLine()); }
            Came came = new Came();
            Implemented implemented = new Implemented();
            WrittenOff writtenOff = new WrittenOff();
            Transferred transferred = new Transferred();
            for (; ; )
            {
                Console.WriteLine("Выберите управление товаром:\n0 - Пришло\n1 - Реализовано\n2 - Списано\n3 - Передано");
                int a = input();
                Console.WriteLine("Выберите действие:\n0 - Добавить товар\n1 - Показать список");
                int b = input();
                switch (a)
                {
                    case 0:
                        if (b == 0) came.Add();
                        else if (b == 1) came.PrintList();
                        break;
                    case 1:
                        if (b == 0) implemented.Add();
                        else if (b == 1) implemented.PrintList();
                        break;
                    case 2:
                        if (b == 0) writtenOff.Add();
                        else if (b == 1) writtenOff.PrintList();
                        break;
                    case 3:
                        if (b == 0) transferred.Add();
                        else if (b == 1) transferred.PrintList();
                        break;
                    default: break;
                }
            }
        }
    }
}
