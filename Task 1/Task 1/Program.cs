class Program
{
    static void Main()
    {
        Address myAddress = new Address();

        myAddress.Index = "12345";
        myAddress.Country = "Ukraine";
        myAddress.City = "Kyiv";
        myAddress.Street = "Revutskogo street";
        myAddress.House = "10";
        myAddress.Apartment = "5";

        Console.WriteLine("My Adress:");
        Console.WriteLine($"Index: {myAddress.Index}");
        Console.WriteLine($"Country: {myAddress.Country}");
        Console.WriteLine($"City: {myAddress.City}");
        Console.WriteLine($"Street: {myAddress.Street}");
        Console.WriteLine($"House: {myAddress.House}");
        Console.WriteLine($"Apartament: {myAddress.Apartment}");

        Console.ReadLine();
    }
}
