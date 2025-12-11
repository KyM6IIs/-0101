using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static Task4.Program.Mage;

namespace Task4
{

    class Program
    {
        public interface IAttack
        {
            void Attack();
        }
        public interface IHeal
        {
            void Heal();
        }

        public class Mage : IAttack, IHeal
        {
            public string Name { get; set; }

            public Mage(string name)
            {
                Name = name;
            }

            public void Attack()
            {
                Console.WriteLine($"{Name} выпускает ледяной шар");
            }

            public void Heal()
            {
                Console.WriteLine($"{Name} лечится!");
            }
            public class Warrior : IAttack
            {
                public string Name { get; set; }

                public Warrior(string name)
                {
                    Name = name;
                }

                public void Attack()
                {
                    Console.WriteLine($"{Name} атакует ");
                }
            }
        }
        static void Main()
        {
         
            object[] players = new object[]
            {
                    new Warrior("боб"),
                    new Mage("сэм"),
                    new Warrior("артур"),
                    new Mage("пэпт")
            };

            Console.WriteLine("Все, кто умеет атаковать:");
            foreach (var player in players)
            {
                if (player is IAttack attacker)
                {
                    attacker.Attack();
                }
            }

            Console.WriteLine("только те, кто умеет лечить:");

            
            foreach (var player in players)
            {
                if (player is IHeal healer)
                {
                    healer.Heal();
                }
            }
        }
    }

}