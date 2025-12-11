using System;

public class Circle
{
    private double radius;

    public double Radius
    {
        get { return radius; }
        set
        {
            if (value > 0)
            {
                radius = value;
            }
            else
            {
                Console.WriteLine("радиус должен быть больше 0!");
                radius = 1;
            }
        }
    }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public void GetArea()
    {
        double area = Math.PI * radius * radius;
        Console.WriteLine($"площадь круга: {area}.");
    }

    static void Main()
    {
        Circle circle1 = new Circle(5);
        circle1.GetArea();

        circle1.Radius = -2;
        circle1.GetArea();
    }
}