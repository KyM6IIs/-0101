using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "мама мыла раму мама мыла";
            Console.WriteLine($"Текст: {text}");
            string[] words = text.Split(' ');
            Dictionary<string, int> result = new Dictionary<string, int>();
            foreach (string w in words)
            {
                string word = w.ToLower();
                if (result.ContainsKey(word))
                {
                    result[word]++;
                }
                else
                {
                    result[word] = 1;
                }
            }
            Console.WriteLine("результат:");
            foreach (var pair in result)
            {
                Console.WriteLine(pair.Key + "-" + pair.Value);
            }
        }
    }
}