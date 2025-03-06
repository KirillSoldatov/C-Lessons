namespace CurrencyLibrary;

public class CurrencyConverter
{
    private const int CourseRubToUsd = 100;
    private const int CourseRubToEur = 105;

    private const int CourseUsdToRub = 97;
    private const int CourseEurToRub = 102;

    public decimal ConverterToUsd(decimal sum, string currency)
    {
        if (currency == CurrencyHelper.Usd)
        {
            return sum;
        }

        if (currency == CurrencyHelper.Eur)
        {
            return sum * CourseEurToRub / CourseRubToUsd;
        }

        return sum / CourseRubToUsd;
    }
}

