namespace OOPPrinciples;

public class People
{
    public People(string fullName, int age, Sex sex)
    {
        FullName = fullName;
        Age = age;
        Sex = sex;
    }

    public string FullName { get; set; }
    public int Age { get; set; }
    public Sex Sex { get; set; }
    
    
    
}