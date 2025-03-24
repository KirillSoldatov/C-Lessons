namespace StockExchange;

public class Bond : InvestmentSecurity
{
    public override TypeOfInvestment Type
    {
        get { return TypeOfInvestment.Bond; }
    }
    public double InterestRate { get; init; }
    public int Quantity { get; init; }
    public int MaturityFrequency { get; init; }
}