namespace StockExchange;

public class StockFactory : IInvestmentSecurityFactory
{
    private int _quantity;
    private InvestmentSecurity _investmentSecurity;
    
    public StockFactory(int quantity, InvestmentSecurity investmentSecurity)
    {
        _quantity = quantity;
        _investmentSecurity = investmentSecurity;
    }
    
    public InvestmentSecurity CreateInvestSecurity()
    {
        string name = Guid.NewGuid().ToString();
        
        InvestmentSecurity stock = new Stock()
        {
            Quantity = _quantity,
            InitialPrice = _investmentSecurity.InitialPrice,
            IssuerName = _investmentSecurity.IssuerName,
            IssueDate = DateTime.Now,
            Name = name,
            Ticker = $"{_investmentSecurity.IssuerName}_{name}",
            MaturityDate = _investmentSecurity.MaturityDate,
        };
        
        return stock;
    }
}