using System;

class Employee
{
    public string Name { get; set; }

    public virtual double GetBonus()
    {
        return 1000;
    }
}

class Manager : Employee
{
    public override double GetBonus()
    {
        return 5000;
    }
}

class Engineer : Employee
{
    public override double GetBonus()
    {
        return 3000;
    }
}

class Program
{
    static void Main()
    {
        Employee e1 = new Manager();
        Employee e2 = new Engineer();

        Console.WriteLine("Manager Bonus: " + e1.GetBonus());
        Console.WriteLine("Engineer Bonus: " + e2.GetBonus());
    }
}
