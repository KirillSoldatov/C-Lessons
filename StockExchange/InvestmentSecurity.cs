namespace StockExchange;

public abstract class InvestmentSecurity : InvestmentElement
{
    public string IssuerName { get; init; }
    public DateTime MaturityDate { get; init; }
    public DateTime IssueDate { get; init; }
}