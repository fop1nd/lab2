using System;

using System;

class Converter
{
    private double usdRate;
    private double eurRate;
    private double plnRate;

    public Converter(double usd, double eur, double pln)
    {
        usdRate = usd;
        eurRate = eur;
        plnRate = pln;
    }

    public double ConvertToCurrency(double amount, string currency)
    {
        double result = 0;

        switch (currency.ToLower())
        {
            case "usd":
                result = amount / usdRate;
                break;
            case "eur":
                result = amount / eurRate;
                break;
            case "pln":
                result = amount / plnRate;
                break;
            default:
                Console.WriteLine("Неправильно введено валюту.");
                break;
        }

        return result;
    }

    public double ConvertFromCurrency(double amount, string currency)
    {
        double result = 0;

        switch (currency.ToLower())
        {
            case "usd":
                result = amount * usdRate;
                break;
            case "eur":
                result = amount * eurRate;
                break;
            case "pln":
                result = amount * plnRate;
                break;
            default:
                Console.WriteLine("Неправильно введено валюту.");
                break;
        }

        return result;
    }
}