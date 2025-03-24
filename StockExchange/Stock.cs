namespace StockExchange;

public class Stock : InvestmentSecurity
{
    public override TypeOfInvestment Type
    {
        get { return TypeOfInvestment.Stock; }
    }
    public int Quantity { get; set; }
}