class Program
{
    static void Main()
    {
        Employee employee = new Employee("Petrov", "Ivan");

        employee.CalculateSalaryAndTax("developer", 5);

        Console.ReadLine();
    }
}