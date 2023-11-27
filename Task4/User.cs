using System;

class User
{
    private string login;
    private string firstName;
    private string lastName;
    private int age;
    private readonly DateTime registrationDate;

    public User(string login, string firstName, string lastName, int age)
    {
        this.login = login;
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        registrationDate = DateTime.Now;
    }

    public void DisplayUserInfo()
    {
        Console.WriteLine("Information about the user:");
        Console.WriteLine($"login: {login}");
        Console.WriteLine($"firstName: {firstName}");
        Console.WriteLine($"lastName: {lastName}");
        Console.WriteLine($"age: {age}");
        Console.WriteLine($"registrationDate: {registrationDate}");
    }
}