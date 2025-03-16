using CurrencyLibrary;

namespace OOPPrinciples;

public class SuperCurrencyConverter: CurrencyConverter
{
    public SuperCurrencyConverter()
    {
        coefficient = 100;
    }
}