using System;

namespace Project_30
{
    struct Client_06
    {
        private int Cod;
        private string FIO;
        private string Adress;
        private int Telephone;
        private int Count;
        private double Money;
        private ClientType Type;
        public enum ClientType //Важность клиента
        {
            Незаметный, Значительный, Важнейший
        }
        public Client_06(int Cod, string FIO, string Adress, int Telephone, int Count, double Money)
        {
            this.Cod = Cod;
            this.FIO = FIO;
            this.Adress = Adress;
            this.Telephone = Telephone;
            this.Count = Count;
            this.Money = Money;
            if (this.Money <= 1000) this.Type = ClientType.Незаметный;
            else if (this.Money > 1000 && this.Money <= 2000) this.Type = ClientType.Значительный;
            else this.Type = ClientType.Важнейший;
        }
        public void Print()
        {
            Console.WriteLine($"Код клиента {Cod},\n ФИО клиента {FIO},\n Адрес клиента {Adress},\n Телефон клиента {Telephone},\n Количество заказов клиента {Count},\n Общая сумма заказов клиента {Money},\n Важность клиента - {Type}.");
        }
    }
    class Task_06
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
            Client_06 client =
            new Client_06(cod, fio, adress, telephone, count, money);
            client.Print();
        }
    }
}
