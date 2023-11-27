class Program
{
    static void Main()
    {
        User user = new User("user123", "Ivan", "Petrov", 30);

        user.DisplayUserInfo();

        Console.ReadLine();
    }
}