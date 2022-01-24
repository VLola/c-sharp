using System;

namespace Project_30
{
    struct Article
    {
        private int Cod;
        public string Name;
        private double Price;
        public Article(int cod, string name, double price)
        {
            Cod = cod;
            Name = name;
            Price = price;
        }
        public void Print()
        {
            Console.WriteLine($"Код товара {Cod}, Название товара {Name}, Цена товара {Price}.");
        }
    }
    class Task_01
    {
        public void Start()
        {
            Console.WriteLine("Введите код товара");
            int cod = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите название товара");
            string name = Console.ReadLine();
            Console.WriteLine("Введите цену товара");
            double price = Convert.ToDouble(Console.ReadLine());
            Article article =
            new Article(cod, name, price);
            article.Print();
        }
    }
}
