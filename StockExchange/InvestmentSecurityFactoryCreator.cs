namespace StockExchange;

public static class InvestmentSecurityFactoryCreator
{
    public static IInvestmentSecurityFactory CreateBondFactory(double interestRate, int maturityFrequency, int quantity, InvestmentSecurity investmentSecurity)
    {
        return new BondFactory(interestRate, maturityFrequency, quantity, investmentSecurity);
    }

    public static IInvestmentSecurityFactory CreateStockFactory(int quantity, InvestmentSecurity investmentSecurity)
    {
        return new StockFactory(quantity, investmentSecurity);
    }
}