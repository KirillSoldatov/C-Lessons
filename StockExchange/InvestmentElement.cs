namespace StockExchange;

public abstract class InvestmentElement
{
    public string Name { get; init; }
    public abstract TypeOfInvestment Type { get;}
    public string Ticker { get; init; }
    public decimal InitialPrice { get; init; }
}