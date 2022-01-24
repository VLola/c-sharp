using System;

namespace Project_30
{
    struct Client
    {
        private int Cod;
        private string FIO;
        private string Adress;
        private int Telephone;
        private int Count;
        private double Money;
        public Client(int cod, string fio, string adress, int telephone, int count, double money)
        {
            Cod = cod;
            FIO = fio;
            Adress = adress;
            Telephone = telephone;
            Count = count;
            Money = money;
        }
        public void Print()
        {
            Console.WriteLine($"Код клиента {Cod},\n ФИО клиента {FIO},\n Адрес клиента {Adress},\n Телефон клиента {Telephone},\n Количество заказов клиента {Count},\n Общая сумма заказов клиента {Money}.");
        }
    }
    class Task_02
    {
        public void Start()
        {
            Console.WriteLine("Введите код клиента");
            int cod = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите ФИО клиента");
            string fio = Console.ReadLine();

            Console.WriteLine("Введите Адрес клиента");
            string adress = Console.ReadLine();

            Console.WriteLine("Введите Телефон клиента");
            int telephone = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество заказов клиента");
            int count = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите общую сумму заказов клиента клиента");
            double money = Convert.ToDouble(Console.ReadLine());
            Client client =
            new Client(cod, fio, adress, telephone, count, money);
            client.Print();
        }
    }
}
