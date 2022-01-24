using System;

namespace Project_32
{
    class Program
    {
        static void Main(string[] args)
        {
            Russia.Moscow Moscow = new Russia.Moscow();
            Ukraine.Kiev Kiev = new Ukraine.Kiev();
            Germany.Berlin Berlin = new Germany.Berlin();


            if (Moscow.people > Kiev.people && Moscow.people > Berlin.people)
            {
                Console.WriteLine($"Население Москвы {Moscow.people}");
                Console.WriteLine($"Больше чем в Киеве на {Moscow.people - Kiev.people} человек");
                Console.WriteLine($"Больше чем в Берлине на {Moscow.people - Berlin.people} человек");
            }
            else if (Kiev.people > Moscow.people && Kiev.people > Berlin.people)
            {
                Console.WriteLine($"Население Киева {Kiev.people}");
                Console.WriteLine($"Больше чем в Москве на {Kiev.people - Moscow.people} человек");
                Console.WriteLine($"Больше чем в Берлине на {Kiev.people - Berlin.people} человек");
            }
            else if (Berlin.people > Moscow.people && Berlin.people > Kiev.people)
            {
                Console.WriteLine($"Население Берлина {Berlin.people}");
                Console.WriteLine($"Больше чем в Москве на {Berlin.people - Moscow.people} человек");
                Console.WriteLine($"Больше чем в Киеве на {Berlin.people - Kiev.people} человек");
            }
        }
    }
}
