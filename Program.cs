using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var8zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string sentence = Console.ReadLine();

            string processedSentence = RemoveShortWords(sentence);

            Console.WriteLine("\nОбработанное предложение:");
            Console.WriteLine(processedSentence);
            Console.ReadKey();
        }

        static string RemoveShortWords(string sentence)
        {
            // Разбиваем предложение на слова, используя пробелы как разделители
            string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Фильтруем слова, оставляя только те, которые имеют длину 3 и более символов
            string[] filteredWords = words.Where(word => word.Length >= 3).ToArray();


            // Объединяем отфильтрованные слова обратно в предложение
            return string.Join(" ", filteredWords);
        }
    }
}
    
