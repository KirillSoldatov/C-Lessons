namespace TypeOperationsLesson;

class Program
{
    static void Main(string[] args) 
    {

		CheckBodyMassIndex(GetBodyMassIndex(75.3, 1.90));
		
		Console.Write("Введите целое число: ");
		CheckEvenNumbers(InputData());
		
		Console.Write("Введите год: ");
		CheckLeapYear(InputData());
		
		ReplaceNumbers(5, 3);
    }
	
	static double GetBodyMassIndex(double weight, double height)
	{
		double bmi = weight / Math.Pow(height, 2);
		return Math.Round(bmi, 2);
	}
	
	static void CheckBodyMassIndex(double bmi)
	{
		if (bmi < 18.5)
		{
			Console.WriteLine($"bmi={bmi}, результат : недостающий вес");
		}
		else if (18.5 <= bmi && bmi < 24.9)
		{
			Console.WriteLine($"bmi={bmi}, результат : норма");
		}
		else if (25.0 <= bmi && bmi < 29.9)
		{
			Console.WriteLine($"bmi={bmi}, результат : избыточный вес");
		}
		else if (bmi >= 30.0)
		{
			Console.WriteLine($"bmi={bmi}, результат : ожирение");
		}
	}
	
	static int InputData()
	{	
		int userNumber = int.Parse(Console.ReadLine());
		return userNumber;
	}
	
	static void CheckEvenNumbers(int number)
	{
		Console.WriteLine(number % 2 == 0 ? "Число является четным" : "Число является нечетным");
	}
	
	static void CheckLeapYear(int year)
	{
		if (year % 4 == 0 && year % 100 != 0)
		{
			Console.WriteLine($"Год {year} является високосным");
		}
		else if (year % 400 == 0)
		{
			Console.WriteLine($"Год {year} является високосным");
		}
		else
		{
			Console.WriteLine($"Год {year} не является високосным");
		}
	}
	
	static void ReplaceNumbers(int first, int second)
	{
		Console.WriteLine($"До замены : first = {first}, second = {second}");
		
		/*
		int temp = first;
		first = second;
		second = temp;
		*/
		
		first = first + second;
		second = first - second;
		first = first - second;
		
		Console.WriteLine($"После замены : first = {first}, second = {second}");
	}
}
