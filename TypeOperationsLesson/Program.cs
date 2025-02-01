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
    }
	
	static double GetBodyMassIndex(double weight, double height)
	{
		double bmi = weight / Math.Pow(height, 2);
		return Math.Round(bmi, 2);
	}
	
	static void CheckBodyMassIndex(double bmi)
	{
		switch (bmi)
		{
			case < 18.5:
				Console.WriteLine($"bmi={bmi}, результат : недостающий вес");
				break;
				
			case < 24.9:
				Console.WriteLine($"bmi={bmi}, результат : норма");
				break;
			
			case 25:
				Console.WriteLine($"bmi={bmi}, результат : избыточный вес");
				break;
			
			case < 29.9:
				Console.WriteLine($"bmi={bmi}, результат : избыточный вес");
				break;
				
			case >= 30:
				Console.WriteLine($"bmi={bmi}, результат : ожирение");
				break;
		}
	}
	
	static int InputData()
	{	
		int userNumber = int.Parse(Console.ReadLine());
		return userNumber;
	}
	
	static void CheckEvenNumbers(int number)
	{
		if (number%2 == 0)
		{
			Console.WriteLine($"Число {number} является четным");
		}
		else
		{
			Console.WriteLine($"Число {number} является нечетным");	
		}
	}
	
	static void CheckLeapYear(int year)
	{
		if (year%4 == 0 && year%100 != 0 || year%400 == 0)
		{
			Console.WriteLine($"Год {year} является високосным");
		}
		else
		{
			Console.WriteLine($"Год {year} не является високосным");
		}
	}
}
