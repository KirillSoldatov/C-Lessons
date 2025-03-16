using CurrencyLibrary;

namespace OOPPrinciples;

public class Student: People, IMoveable, ISportsMan, ICloneable
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

        if (TypeOfStudy == TypeOfStudy.University && intelligent < 100)
        {
            throw new Exception("You are not allowed to study in University");
        }
    }

    public void Introduce()
    {
        Console.WriteLine($"Full name : {FullName}, age : {_age}, type of study : {TypeOfStudy}");
    }

    public override void Say()
    {
        base.Say();
        Console.WriteLine($"Grant - {Grant}");
    }

    public override void Eat()
    {
        Console.WriteLine("Студент кушает в столовой");
    }

    void IMoveable.Move()
    {
        Console.WriteLine("I am student. I am walking");
    }

    void ISportsMan.Move()
    {
        Console.WriteLine("I am student. I am running");
    }

    public object Clone()
    {
        return new Student(FullName, Age, TypeOfStudy, Sex);
    }
}