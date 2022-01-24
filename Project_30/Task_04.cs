using System;

namespace Project_30
{
    public enum RequestType
    {
        Конверт = 5,
        Открытка = 6,
        Карандаш = 7,
        Ручка = 9,
        Блокнот = 10,
        Папка = 11,
        Маркер = 13,
        Календарь = 15,
        Линейка = 18,
        Дневник = 20,
        Дырокол = 25,
        Бумага = 50
    }
    struct Request
    {
        private int Cod;
        public string Client;
        private DateTime Date;
        private int Money;


        public Request(int Cod, string Client, DateTime Date, Array list)
        {
            Money = 0;
            this.Cod = Cod;
            this.Client = Client;
            this.Date = Date;
            Console.WriteLine("Перечень:");
            for (int i = 1; i < 13; i++)
            {
                foreach (int j in list)
                    if (i == j)
                    {
                        RequestType type = (RequestType)Enum.GetValues(typeof(RequestType)).GetValue(i - 1);
                        Money += type.GetHashCode();
                        Console.WriteLine($"Товар: {type}, Цена: {type.GetHashCode()}");
                    }
            }
        }
        public void Print()
        {
            Console.WriteLine($"\nКод клиента {Cod},\nИмя клиента {Client},\nДата заказа {Date.ToShortDateString()},\nОбщая сумма {Money}.");
        }
    }
    class Task_04
    {
        public void Start()
        {
            int[] list = new int[0];
            Console.WriteLine("Введите код Заказа");
            int cod = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите имя Клиента");
            string name = Console.ReadLine();
            Console.WriteLine("Введите дату заказа (Пример: day.mounth.year или day.mounth)");
            DateTime price = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Введите перечень заказанных товаров: \n1 - Конверт\n2 - Открытка\n3 - Карандаш\n4 - Ручка\n5 - Блокнот\n6 - Папка\n7 - Маркер\n8 - Календарь\n9 - Линейка\n10 - Дневник\n11 - Дырокол\n12 - Бумага\n0 - Окончить перечень товаров.");
            for (int i = 0; ; i++)
            {
                Console.WriteLine("Введите номер товара:");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == 0) break;
                Array.Resize(ref list, list.Length + 1);
                list[i] = number;
            }


            Request article = new Request(cod, name, price, list);
            article.Print();
        }
    }
}
