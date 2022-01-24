using System;
using static System.Console;

namespace Project_28
{
    class Task_2
    {
        public void Start()
        {
            WriteLine("Задание 2:");
            // Начальный вклад
            double S = 10000;
            // Конечная сумма
            double Smax = 11000;
            // Процентная ставка
            double P;
            for (; ; )
            {
                WriteLine("Введите процентную ставку");
                // Ввод процентной ставки
                P = Convert.ToDouble(ReadLine());
                // Проверка условия процентной ставки
                if (P > 0 && P < 25) break;
                else WriteLine("Процентная ставка должна быть: 0<P<25");
            }
            int K = 0;
            for (; ; )
            {
                // Формула увеличения начального вклада
                S += S / 100 * P;
                // Подсчет месяцев
                K++;
                if (S > Smax) break;
            }
            WriteLine("Через " + K + " месяцев начальный вклад составил " + S);
        }
    }
}
