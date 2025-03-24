namespace StockExchange;

public class BondFactory : IInvestmentSecurityFactory
{
    private double _interestRate;
    private int _maturityFrequency;
    private int _quantity;
    private InvestmentSecurity _investmentSecurity;
    
    public BondFactory(double interestRate, int maturityFrequency, int quantity, InvestmentSecurity investmentSecurity)
    {
        _interestRate = interestRate;
        _maturityFrequency = maturityFrequency;
        _quantity = quantity;
        _investmentSecurity = investmentSecurity;
    }
    
    public InvestmentSecurity CreateInvestSecurity()
    {
        string name = Guid.NewGuid().ToString();
        
        InvestmentSecurity bond = new Bond()
        {
            Quantity = _quantity,
            InitialPrice = _investmentSecurity.InitialPrice,
            InterestRate = _interestRate,
            MaturityFrequency = _maturityFrequency,
            IssuerName = _investmentSecurity.IssuerName,
            MaturityDate = _investmentSecurity.MaturityDate,
            IssueDate = DateTime.Now,
            Name = name,
            Ticker = $"{_investmentSecurity.IssuerName}_{name}"
        };
        
        return bond;
    }
}