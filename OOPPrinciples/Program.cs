namespace OOPPrinciples;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("Ivan Ivanov", 21, TypeOfStudy.School, Sex.Male);
        
        student.Introduce();
        
        Console.WriteLine(student.FullName);

        student.TypeOfStudy = TypeOfStudy.University;
        
        student.Introduce();
        
        Console.WriteLine(student.Grant);
    }
}