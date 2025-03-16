namespace OOPPrinciples;

public class Employee: People
{
    public string Company { get; set; }
    
    public Employee(string fullName, int age, Sex sex, string company) : base(fullName, age, sex)
    {
        Company = company;
    }

    public override void Eat()
    {
        Console.WriteLine("Employee eats in cafe");
    }
}