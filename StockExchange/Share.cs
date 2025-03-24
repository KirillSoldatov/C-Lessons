namespace StockExchange;

public class Share : InvestmentElement
{
    public override TypeOfInvestment Type
    {
        get { return TypeOfInvestment.Share; }
    }
    public decimal Quantity { get; init; }
}