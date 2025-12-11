using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main()
        {

            List<IOnOff> devices = new List<IOnOff>()
        {
            new Lamp("Лампа у кровати"),
            new Fan("Вентилятор в комнате")
        };


            foreach (var device in devices)
            {
                device.TurnOn();

               
                if (device is Ilevel levelble)
                {
                    levelble.SetLevel(30);
                }

                device.TurnOff();
                Console.WriteLine();
            }
        }


    public class Fan : IOnOff
        {
            public string Name { get; set; }
            public bool IsOn { get; set; }

            public Fan(string name)
            {
                Name = name;
                IsOn = false;
            }

           
            public void TurnOn()
            {
                IsOn = true;
                Console.WriteLine($"{Name} включен.");
            }

            
            public void TurnOff()
            {
                IsOn = false;
                Console.WriteLine($"{Name} выключен.");
            }
        }
        public interface IOnOff
        {
            void TurnOn();
            void TurnOff();
        }
        public interface Ilevel
        {
            void SetLevel(int level);
        }
        public class Lamp : IOnOff, Ilevel

        {
            public string Name { get; set; }
            public bool IsOn { get; set; }
            public int Level { get; set; }

            public Lamp(string name)
            {
                Name = name;
                IsOn = false;
                Level = 0;
            }
            public void TurnOn()
            {
                IsOn = true;
                Level = 100;
                Console.WriteLine($"{Name} вкл. лвл: {Level}");
            }
            public void TurnOff()
            {
                IsOn = false;
                Level = 0;
                Console.WriteLine($"{Name} выкл.");
            }
            public void SetLevel(int level)
            {
                if (!IsOn)
                {
                    Console.WriteLine($"{Name} выкл, нельзя установить уровень.");
                    return;
                }

                if (level < 0) level = 0;
                if (level > 100) level = 100;

                Level = level;
                Console.WriteLine($"{Name}: уровень установлен на {Level}");
            }
        }
    }
}

        
            