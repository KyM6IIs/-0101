using System;

public class bankAccount
{
    private string owner;
    private double balance;

    public string Owner
    {
        get { return owner; }
        set { owner = value; }
    }


    public double Balance
    {
        get { return balance; }
        set
        {
            if (value >= 0)
            {
                balance = value;
            }
            else
            {
               
                Console.WriteLine("баланс не может быть отрицательным!");
            }
        }
    }
    public bankAccount(string owner, double balance)
    {
        Owner = owner;
        Balance = balance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
        Console.WriteLine($"{Owner}, баланс: {Balance}.");
    }
    public void Withdraw(double amount)
    {
        if (amount > 0)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            }
            else


            {
                Console.WriteLine("Недостаточно средств!");
            }
        }
        Console.WriteLine($"{Owner}, баланс: {Balance}.");
    }
    static void Main()
    {
        bankAccount account = new bankAccount("Иван", 1000);
        account.Deposit(500);
        account.Withdraw(500);
        account.Withdraw(2000);

    }
}