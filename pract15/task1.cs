using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
  
public interface IRechargeable
    {
        void Recharge();
    }
}
    public interface IRechargeable
    {
        void Recharge();
    }
    public interface IWorkable
{
    void DoWork();
}

public class Robot : IWorkable, IRechargeable
{
    public string Name { get; set; }
    public int Energy { get; set; }

    public Robot(string name, int energy)
    {
        Name = name;
        Energy = energy;
    }

    public void DoWork()
    {

        if (Energy >= 20)
        {
            Energy -= 20;
            Console.WriteLine($"{Name} поработал. Зарядка: {Energy}");
        }
        else
        {
            Console.WriteLine($"{Name} устал. Зарядка: {Energy}");
        }
    }

    
    public void Recharge()
    {
        Energy += 50;
        if (Energy > 100)
            Energy = 100;

        Console.WriteLine($"{Name} зарядился. Зарядка: {Energy}");
    }
}

class Program
{
    static void Main()
    {

        Robot r1 = new Robot("робот", 60);


        r1.DoWork();
        r1.DoWork();
        r1.Recharge();
        r1.DoWork();

       
        Console.WriteLine($"Итог: {r1.Name}, зарядка: {r1.Energy}");
    }
}
