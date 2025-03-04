namespace OOPPrinciples;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("Ivan Ivanov", 21, TypeOfStudy.School);
        
        student.Introduce();
    }
}