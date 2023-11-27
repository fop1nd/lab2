class Program
{
    static void Main()
    {
        Converter converter = new Converter(28.3, 33.2, 7.1);

        double amountInUah = 1000;
        double convertedToUsd = converter.ConvertToCurrency(amountInUah, "usd");
        Console.WriteLine($"{amountInUah} UAH = {convertedToUsd} USD");

        double amountInUsd = 50;
        double convertedToUah = converter.ConvertFromCurrency(amountInUsd, "usd");
        Console.WriteLine($"{amountInUsd} USD = {convertedToUah} UAH");

        Console.ReadLine();
    }
}