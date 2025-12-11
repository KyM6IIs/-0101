using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Task3;

namespace Task3
{
    class Program
    {
        public class Phone : IPriceable, IWarrantyper
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int WarrantyMonths { get; set; }

            public Phone(string name, decimal price, int warrantyMonths)
            {
                Name = name;
                Price = price;
                WarrantyMonths = warrantyMonths;
            }

            public decimal GetPrice()
            {
                return Price;
            }

            public int GetWarrantyMonths()
            {
                return WarrantyMonths;
            }
        }
        static void Main()
        {
            
            List<object> products = new List<object>()
        {
            new Phone("Samsung", 25000m, 12),
            new Laptop("Acer", 40000m),
            new Phone("iPhone", 80000m, 24)
        };

            decimal total = 0;

            Console.WriteLine("Магазин техники:\n");

            foreach (var item in products)
            {
               
                if (item is IPriceable priceable)
                {
                    decimal price = priceable.GetPrice();
                    total += price;
                    Console.WriteLine($"{item.GetType().Name}: {price} руб.");
                }

                
                if (item is IWarrantyper warrantable)
                {
                    Console.WriteLine($"  Гарантия: {warrantable.GetWarrantyMonths()} мес.");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Общая стоимость всех товаров: {total} руб.");
        }
    }
    public interface IPriceable
    {
        decimal GetPrice();
    }

    public interface IWarrantyper
    {
        int GetWarrantyMonths();
    }

    public class Laptop : IPriceable
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Laptop(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public decimal GetPrice()
        {
            return Price;
        }

        public class Phone : IPriceable, IWarrantyper
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int WarrantyMonths { get; set; }

            public Phone(string name, decimal price, int warrantyMonths)
            {
                Name = name;
                Price = price;
                WarrantyMonths = warrantyMonths;
            }

            public decimal GetPrice()
            {
                return Price;
            }

            public int GetWarrantyMonths()
            {
                return WarrantyMonths;
            }
        }

         static void Main()
        {
            
            List<object> products = new List<object>()
        {
            new Phone("Samsung", 25000m, 12),
            new Laptop("Acer", 40000m),
            new Phone("iPhone", 80000m, 24)
        };

            decimal total = 0;

            Console.WriteLine("Магазин техники:\n");

            foreach (var item in products)
            {
                
                if (item is IPriceable priceable)
                {
                    decimal price = priceable.GetPrice();
                    total += price;
                    Console.WriteLine($"{item.GetType().Name}: {price} руб.");
                }

               
                if (item is IWarrantyper warrantable)
                {
                    Console.WriteLine($"  Гарантия: {warrantable.GetWarrantyMonths()} мес.");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Общая стоимость всех товаров: {total} руб.");
        }
    }
    }