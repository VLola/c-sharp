using System;

namespace Project_30
{
    public enum ArticleType_05
    {
        Chemistry, Food, Clothing
    }
    struct Article_05
    {
        private int Cod;
        public string Name;
        private double Price;
        private ArticleType_05 Type;


        public Article_05(int cod, string name, double price, ArticleType_05 type)
        {
            Cod = cod;
            Name = name;
            Price = price;
            Type = type;
        }
        public void Print()
        {
            Console.WriteLine($"Код товара {Cod},\n Название товара {Name},\n Цена товара {Price},\n Тип товара {Type}.");
        }
    }
    class Task_05
    {
        public void Start()
        {
            Console.WriteLine("Введите код товара");
            int cod = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите название товара");
            string name = Console.ReadLine();
            Console.WriteLine("Введите цену товара");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите тип товара: 1 - Химия, 2 - Еда, 3 - Одежда");
            int number = Convert.ToInt32(Console.ReadLine());
            ArticleType_05 type = (ArticleType_05)
            Enum.GetValues(typeof(ArticleType_05)).
            GetValue(number - 1);
            Article_05 article =
            new Article_05(cod, name, price, type);
            article.Print();
        }
    }
}
