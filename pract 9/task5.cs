using System;

public class Phone
{private string brand;
    private int batteryLevel;
    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }
    public int BatteryLevel
    {
        get { return batteryLevel; }
        set
        {
            if (value >= 0 && value <= 100)
            {
                batteryLevel = value;
            }
            else
            {
                Console.WriteLine("Заряд должен быть от 0 до 100!");
            }
        }
    }
   public Phone(string brand, int batteryLevel)
    {
        Brand = brand;
        BatteryLevel = batteryLevel;
    }

    public void UsePhone()
    {
        BatteryLevel -= 10;
       if (BatteryLevel < 0)
        {
            BatteryLevel = 0;
        }
        Console.WriteLine($"Телефон {Brand}, заряд: {BatteryLevel}%");
    }

    static void Main()
    {
        Phone phone = new Phone("Samsung", 90);
        phone.UsePhone();
        phone.UsePhone();

        phone.BatteryLevel = -10;
        phone.UsePhone();
    }
}