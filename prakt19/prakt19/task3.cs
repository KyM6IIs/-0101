using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> stock = new Dictionary<string, int>();
            stock["Молоко"] = 15;
            stock["Хлеб"] = 9;
            stock["Яйца"] = 20;
            stock["Сахар"] = 10;
            stock["Масло"] = 5;
            stock["Соль"] = 8;

            List<string> sold = new List<string>();
            Console.WriteLine("Продаем товары:");
            if (stock["Молоко"] > 0)
            {
                stock["Молоко"]--;
                sold.Add("Молоко");
                Console.WriteLine("молоко продано");
            }
            if (stock["Молоко"] > 0)
            {
                stock["Молоко"]--;
                sold.Add("Молоко");
                Console.WriteLine("Молоко продано");
            }
            if (stock["Хлеб"] > 0)
            {
                stock["Хлеб"]--;
                sold.Add("Хлеб");
                Console.WriteLine("Хлеб продан");
            }
            if (stock["Яйца"] > 0)
            {
                stock["Яйца"]--;
                sold.Add("Яйца");
                Console.WriteLine("Яйца проданы");
            }
            Console.WriteLine("Что осталось:");
            Console.WriteLine($"Хлеб: {stock["Хлеб"]}");
            Console.WriteLine($"Молоко: {stock["Молоко"]}");
            Console.WriteLine($"Яйца: {stock["Яйца"]}");
            Console.WriteLine($"Сахар: {stock["Сахар"]}");
            Console.WriteLine($"Масло: {stock["Масло"]}");
            Console.WriteLine($"Соль: {stock["Соль"]}");
            Console.WriteLine("Сколько продали:");

            int milkCount = 0;
            int breadCount = 0;
            int eggsCount = 0;

            foreach (string product in sold)
            {
                if (product == "Молоко") milkCount++;
                if (product == "Хлеб") breadCount++;
                if (product == "Яйца") eggsCount++;
            }

            if (milkCount > 0)
                Console.WriteLine($"Молоко - {milkCount} раза");
            if (breadCount > 0)
                Console.WriteLine($"Хлеб - {breadCount} раз");
            if (eggsCount > 0)
                Console.WriteLine($"Яйца - {eggsCount} раз");
        }
    }
}