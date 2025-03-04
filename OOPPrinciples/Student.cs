namespace OOPPrinciples;

public class Student
{
    private string _fullName;
    private int _age;
    private TypeOfStudy _typeOfStudy;

    public Student(string fullName, int age, TypeOfStudy typeOfStudy)
    {
        _fullName = fullName;
        _age = age;
        _typeOfStudy = typeOfStudy;
    }

    public void Introduce()
    {
        Console.WriteLine($"Full name : {_fullName}, age : {_age}, type of study : {_typeOfStudy}");
    }
}