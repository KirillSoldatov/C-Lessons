namespace OOPPrinciples;

public abstract class People
{
    protected int intelligent;
    public string FullName { get; set; }
    public int Age { get; set; }
    public Sex Sex { get; set; }
    
    public People(string fullName, int age, Sex sex)
    {
        FullName = fullName;
        Age = age;
        Sex = sex;
        intelligent = new Random().Next(100, 150);
    }

    public virtual void Say()
    {
        Console.WriteLine($"Full Name - {FullName}, Sex - {Sex}");
    }

    public abstract void Eat();
}