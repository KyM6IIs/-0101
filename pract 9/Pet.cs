using System;

public class Pet
{
    private string name;
    private int energy;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Energy
    {
        get { return energy; }
        set
        {
            if (value >= 0 && value <= 100)
            {
                energy = value;
            }
            else
            {
                Console.WriteLine("Энергия должна быть от 0 до 100!");
            }
        }
    }
    public Pet(string name, int energy)
    {
        Name = name;
        Energy = energy;
    }
    public void Play()
    {
        Energy -= 20;
        if (Energy < 0)
        {
            Energy = 0;
        }
        Console.WriteLine($"{Name} играет, энергия: {Energy}.");
    }
    public void Rest()
    {
        Energy += 30;
        if (Energy > 100)
        {
            Energy = 100;
        }
        Console.WriteLine($"{Name} отдыхает, энергия: {Energy}.");
    }
    static void Main()
    {
        Pet pet = new Pet("Рекс", 80);
        pet.Play();
        pet.Rest();

        pet.Energy = 150;
        pet.Play();
    }