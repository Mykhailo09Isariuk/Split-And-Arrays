using System;

namespace Split
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть речення >>>  ");
            string sentence = Console.ReadLine();

            // Розбиваємо речення на слова
            string[] words = sentence.Split('');

            // Створюємо колекцію
            List<string> coll = new List<string>(words);

            // Виводимо кожне слово
            for (int i =0; i < coll.Count; i++)
            {
                Console.WriteLine($"Слово {i + 1}: {coll[i]}");
            }

        }
    }
}