namespace StockExchange;

public class PreciousMetal : InvestmentElement
{
    public override TypeOfInvestment Type
    {
        get { return TypeOfInvestment.PreciousMetal; }
    }
    public int Quantity { get; init; }
}