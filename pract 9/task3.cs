using System;

public class Person
{
    private string name;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0 && value <= 120)
            {
                age = value;
            }
            else
            {
                Console.WriteLine("Возраст должен быть от 0 до 120!");
                age = 0;

            }
        }
    }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void SayHello()
    {
        Console.WriteLine($"Привет, я {Name}, мне {Age} лет!");
    }

    static void Main()
    {
        Person person = new Person("Маша", 25);
        person.SayHello();

        person.Age = 150;
        person.SayHello();

        person.Age = -5;
        person.SayHello();
    }
}