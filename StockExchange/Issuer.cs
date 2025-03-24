using System.Runtime.InteropServices.JavaScript;

namespace StockExchange;

public class Issuer
{
    public string Name { get; set; }
    public decimal Capital { get; set; }
    public InvestmentSecurity[] InvestmentSecurity { get; private set; }
    private IInvestmentSecurityFactory _investmentSecurityFactory;
    private int countOfInvestmentSecurity = 0;

    public Issuer(int securityQuantity)
    {
        InvestmentSecurity = new InvestmentSecurity[securityQuantity];
    }

    public void IssueBond(int quantity, double interestRate, int maturityFrequency, int maturityYears)
    {
        _investmentSecurityFactory = InvestmentSecurityFactoryCreator.CreateBondFactory(interestRate,
            maturityFrequency, quantity,
            new Bond()
            {
                Quantity = quantity,
                InitialPrice = 1000,
                InterestRate = interestRate,
                MaturityFrequency = maturityFrequency,
                MaturityDate = DateTime.Now.AddYears(maturityYears),
                IssuerName = Name,
            }
        );

        AddSecurity();
    }
    
    
    public void IssueStock(int quantity, int maturityYears)
    {

        _investmentSecurityFactory = InvestmentSecurityFactoryCreator.CreateStockFactory(quantity,
            new Stock()
            {
                Quantity = quantity,
                InitialPrice = Capital / quantity,
                IssuerName = Name,
                MaturityDate = DateTime.Now.AddYears(maturityYears),
            }
        );

        AddSecurity();
    }

    private void AddSecurity()
    {
        var investmentSecurities = InvestmentSecurity;
        
        if (investmentSecurities.Length == countOfInvestmentSecurity - 1)
        {
            Array.Resize(ref investmentSecurities, countOfInvestmentSecurity * 2);
            InvestmentSecurity = investmentSecurities;
        }
        
        InvestmentSecurity[countOfInvestmentSecurity++] = _investmentSecurityFactory.CreateInvestSecurity();
    }
}