using CurrencyLibrary;

namespace OOPPrinciples;

public class Student: People
{
    private int _age;
    private CurrencyConverter _currencyConverter = new CurrencyConverter();
    public TypeOfStudy TypeOfStudy { private get; set; }

    private decimal _grant;
    public decimal Grant
    {
        get
        {
            return _currencyConverter.ConverterToUsd(_grant, CurrencyHelper.Eur);
        }
        private set
        {
            _grant = value;
        }
    }

    public Student(string fullName, int age, TypeOfStudy typeOfStudy, Sex sex) : base(fullName, age, sex)
    {
        TypeOfStudy = typeOfStudy;
        _grant = 500;
    }

    public void Introduce()
    {
        Console.WriteLine($"Full name : {FullName}, age : {_age}, type of study : {TypeOfStudy}");
    }
}