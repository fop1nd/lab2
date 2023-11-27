using System;

class Employee
{
    private string lastName;
    private string firstName;

    public Employee(string lastName, string firstName)
    {
        this.lastName = lastName;
        this.firstName = firstName;
    }

    public void CalculateSalaryAndTax(string position, int experience)
    {
        double baseSalary = 0;
        double tax = 0;

        switch (position.ToLower())
        {
            case "manager":
                baseSalary = 30000 + (experience * 1000);
                break;
            case "developer":
                baseSalary = 40000 + (experience * 1500);
                break;
            case "analyst":
                baseSalary = 35000 + (experience * 1200);
                break;
            default:
                Console.WriteLine("Unknown position");
                break;
        }

        tax = 0.15 * baseSalary;

        Console.WriteLine($"lastName: {lastName}");
        Console.WriteLine($"firstName: {firstName}");
        Console.WriteLine($"position: {position}");
        Console.WriteLine($"baseSalary: {baseSalary}");
        Console.WriteLine($"tax: {tax}");
    }
}