using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_38
{
    class Program
    {
        public class Money
        {
            public int grn { get; set; }
            public int coin { get; set; }

            public Money()
            {
                grn = 0;
                coin = 0;
            }
            public Money(int a, int b)
            {
                grn = a;
                coin = b;
                Convert();
            }
            public void Convert()
            {
                ConvertGrn();
                CheckBum();
            }
            // Конвертирование если монет меньше 0 или больше 100
            public void ConvertGrn()
            {
                if (coin > 99)
                {
                    grn += 1;
                    coin -= 100;
                    if (coin > 99) ConvertGrn();
                }
                if (coin < 0)
                {
                    grn -= 1;
                    coin += 100;
                    if (coin < 0) ConvertGrn();
                }
            }
            // Проверка на банкрота
            public void CheckBum()
            {
                try
                {
                    if (grn < 0) throw new Exception("Банкрот");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Вы {e.Message}");
                }
            }


            public static Money operator +(Money a, Money b)
            {
                Money c = new Money();
                c.grn = a.grn + b.grn;
                c.coin = a.coin + b.coin;
                c.Convert();
                return c;
            }
            public static Money operator -(Money a, Money b)
            {
                Money c = new Money();
                c.grn = a.grn - b.grn;
                c.coin = a.coin - b.coin;
                c.Convert();
                return c;
            }
            public static Money operator *(Money a, int b)
            {
                Money c = new Money();
                c.grn = a.grn * b;
                c.coin = a.coin * b;
                c.Convert();
                return c;
            }
            public static Money operator /(Money a, int b)
            {
                Money c = new Money();
                c.grn = a.grn / b;
                c.coin = a.coin / b;
                c.Convert();
                return c;
            }
            public static Money operator ++(Money a)
            {
                a.coin++;
                a.Convert();
                return a;
            }
            public static Money operator --(Money a)
            {
                a.coin--;
                a.Convert();
                return a;
            }
            public static bool operator ==(Money a, Money b)
            {
                return a.Equals(b);
            }
            public static bool operator !=(Money a, Money b)
            {
                return !(a == b);
            }
            public static bool operator >(Money a, Money b)
            {
                if (a.grn == b.grn && a.coin > b.coin || a.grn > b.grn) return true;
                else return false;
            }
            public static bool operator <(Money a, Money b)
            {
                if (a.grn == b.grn && a.coin < b.coin || a.grn < b.grn) return true;
                else return false;
            }
            public override bool Equals(object obj) { return this.ToString() == obj.ToString(); }
            public override int GetHashCode() { return this.ToString().GetHashCode(); }
            public override string ToString() { return $"{grn},{coin}"; }
        }
        public static void Print(Money money)
        {
            Console.WriteLine($"{money.grn} гривен, {money.coin} копеек");
        }
        static void Main(string[] args)
        {
            int number;
            int grn;
            int coin;
            Console.WriteLine("Введите сумму первого кошелька:");
            Console.WriteLine("Гривен:");
            grn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Копеек:");
            coin = Convert.ToInt32(Console.ReadLine());
            Money a = new Money(grn, coin);
            Console.WriteLine("Введите сумму второго кошелька:");
            Console.WriteLine("Гривен:");
            grn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Копеек:");
            coin = Convert.ToInt32(Console.ReadLine());
            Money b = new Money(grn, coin);

            Console.Write("Первый кошелёк: ");
            Print(a);
            Console.Write("Второй кошелёк: ");
            Print(b);

            for (; ; )
            {
                Console.WriteLine("Введите действие которое провести с кошельками: +,-,*,/,++,--,==,!=,<,>");
                string sign = Console.ReadLine();
                switch (sign)
                {
                    case "+":
                        Print(a + b);
                        break;
                    case "-":
                        Print(a - b);
                        break;
                    case "*":
                        Console.WriteLine("Введите целое число:");
                        number = Convert.ToInt32(Console.ReadLine());
                        Print(a * number);
                        break;
                    case "/":
                        Console.WriteLine("Введите целое число:");
                        number = Convert.ToInt32(Console.ReadLine());
                        Print(a / number);
                        break;
                    case "++":
                        Print(a++);
                        break;
                    case "--":
                        Print(a--);
                        break;
                    case "==":
                        Console.WriteLine(a == b);
                        break;
                    case "!=":
                        Console.WriteLine(a != b);
                        break;
                    case "<":
                        Console.WriteLine(a < b);
                        break;
                    case ">":
                        Console.WriteLine(a > b);
                        break;
                    default: break;
                }
            }
        }
    }
}
