using System;
using System.Collections;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_39
{
    class Program
    {
        public class Word
        {
            public string Rus { get; set; }
            public string Eng { get; set; }
            public Word(string rus, string eng)
            {
                Rus = rus;
                Eng = eng;
            }
        }
        public class EngRus
        {
            public ArrayList array;
            public EngRus()
            {
                // Добавляем словарь в коллекцию
                array = new ArrayList();
                array.Add(AddWord("Афганистан", "Afghanistan"));
                array.Add(AddWord("Боливия", "Bolivia"));
                array.Add(AddWord("Колумбия", "Colombia"));
                array.Add(AddWord("Гвинея", "Guinea"));
                array.Add(AddWord("Мальдивы", "Maldives"));
                array.Add(AddWord("Иран", "Iran"));
                array.Add(AddWord("Парагвай", "Paraguay"));
                array.Add(AddWord("Словения", "Slovenia"));
            }
            //Иницилизируем класс текста с переводом
            public Word AddWord(string rus, string eng)
            {
                return new Word(rus, eng);
            }
            // Метод перевода на англиский
            public void Eng(string rus)
            {
                foreach (Word it in array)
                {
                    if (rus == it.Rus)
                    {
                        WriteLine($"{rus} = {it.Eng}");
                    }
                }
            }
            // Метод перевода на русский
            public void Rus(string eng)
            {
                foreach (Word it in array)
                {
                    if (eng == it.Eng)
                    {
                        WriteLine($"{eng} = {it.Rus}");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            EngRus a = new EngRus();
            for (; ; )
            {
                WriteLine("Выберите на какой язык хотите перевести: English - 1, Russian - 2");

                switch (Convert.ToInt32(ReadLine()))
                {
                    case 1:
                        WriteLine("Введите слово:");
                        a.Eng(ReadLine());
                        break;
                    case 2:
                        WriteLine("Введите слово:");
                        a.Rus(ReadLine());
                        break;
                    default:
                        break;

                }
            }
        }
    }
}
