﻿namespace TypeOperationsLesson;

class Program
{
    static void Main(string[] args) 
    {
		try
		{
			Console.WriteLine(Calculate(5, 0, ';'));
		}
		catch(DivideByZeroException zero)
		{
			Console.WriteLine($"{zero.Message}");
		}
		catch(ArgumentException aEx)
		{
			Console.WriteLine($"{aEx.Message}");
		}
		/*
		CheckBodyMassIndex(GetBodyMassIndex(75.3, 1.90));
		
		Console.Write("Введите целое число: ");
		CheckEvenNumbers(InputData());
		
		Console.Write("Введите год: ");
		CheckLeapYear(InputData());
		
		ReplaceNumbers(5, 3);
		
		Console.WriteLine(CheckStepChessKnight((3, 5), (4, 7)));
		*/
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
		int userNumber = int.Parse(Console.ReadLine()!);
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
	
	static bool CheckStepChessKnight((int x, int y) firstCoord, (int x, int y) secondCoord)
	{
		bool isCorrectFirstCoord = firstCoord.x > 0 && firstCoord.x < 9 &&  firstCoord.y > 0 && firstCoord.y < 9;
		bool isCorrectSecondCoord = secondCoord.x > 0 && secondCoord.x < 9 &&  secondCoord.y > 0 && secondCoord.y < 9;
		
		int firstDiffX = Math.Abs(firstCoord.x - secondCoord.x);
		int firstDiffY = Math.Abs(firstCoord.y - secondCoord.y);
		
		bool isCorrectDiffX = firstDiffX == 1 || firstDiffX == 2;
		bool isCorrectDiffY = firstDiffY == 1 || firstDiffY == 2;
		
		bool isCorrectDiffXY = isCorrectDiffX && isCorrectDiffY && (firstDiffX + firstDiffY) == 3;
				
		return isCorrectFirstCoord && isCorrectSecondCoord && isCorrectDiffXY;
		
	}
	
	static double Calculate(double first, double second, char symbol)
	{
		switch(symbol)
		{
			case '+':
				return first + second;
				
			case '-':
				return first - second;
				
			case '*':
				return first * second;
				
			case '/':
				return first / second;
				
			default:
				throw new ArgumentException("Введен недопустимый символ");
		}
		
	}
}
