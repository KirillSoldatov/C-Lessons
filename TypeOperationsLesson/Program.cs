﻿namespace TypeOperationsLesson;

class Program
{
	static void Main(string[] args) 
	{
		/*
		byte a = 4;
		byte b = (byte)(a + 70);
		Console.WriteLine(b);
		*/
		InputData();
		InputData();
		
		try
		{	
			int a = 4;
			int b = 70;
			byte c = checked((byte)(a+b));
			Console.WriteLine(c);  //121
		}
		catch (OverflowException ex)
		{
			Console.WriteLine(ex.Message);
		}
		
		//Console.WriteLine(GetDayTime(-5));
		
		//Console.WriteLine(CheckStepChessQueen((4, 6), (4, 1)));
		
		/*
		try
		{
			Console.WriteLine(GetDayTime(3));
		}
		catch (ArgumentOutOfRangeException aEx)
		{
				Console.WriteLine(aEx.Message);
		}
		
		try
		{
			Console.Write("Введите сумму вклада в рублях : ");
			double userDepositAmount = Double.Parse(Console.ReadLine());
			
			Console.Write("Введите процентную ставку (годовую) : ");
			double userInterestRate = Double.Parse(Console.ReadLine());
			
			Console.Write("Введите срок вклада в годах : ");
			double userDepositTime = Double.Parse(Console.ReadLine());
			
			CalculateInterestRate(userDepositAmount, userInterestRate, userDepositTime);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
		
		try
		{
			Console.Write("Введите температуру по Цельсию : ");
			
			double userDegreeCelsius = Double.Parse(Console.ReadLine());
			
			Console.WriteLine(ConvertTemperature(userDegreeCelsius));
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
		
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
		
		CheckBodyMassIndex(GetBodyMassIndex(75.3, 1.90));

		Console.Write("Введите целое число: ");
		CheckEvenNumbers(InputData());
		
		Console.Write("Введите год: ");
		CheckLeapYear(InputData());
		
		ReplaceNumbers(5, 3);
		
		Console.WriteLine(CheckStepChessKnight((3, 5), (4, 1)));
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
		bool checkInput = int.TryParse(Console.ReadLine(), out int userNumber);
		if (checkInput)
		{
			return userNumber;
		}
		throw new ArgumentException("Вы ввели не число");
		
		//int userNumber = int.Parse(Console.ReadLine()!);
		//return userNumber;
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
	
	static bool CheckStepChessQueen((int x, int y) firstCoord, (int x, int y) secondCoord)
	{
		bool isCorrectFirstCoord = firstCoord.x > 0 && firstCoord.x < 9 && firstCoord.y > 0 && firstCoord.y < 9;
		bool isCorrectSecondCoord = secondCoord.x > 0 && secondCoord.y < 9 && secondCoord.y > 0 && secondCoord.y < 9;
		
		int diffXY = secondCoord.x - secondCoord.y;
		
		int sumXY = secondCoord.x + secondCoord.y;
		
		bool isCorrectXY = (diffXY == 1) || (sumXY == 9) || (firstCoord.x == secondCoord.x) || (firstCoord.y == secondCoord.y);
		
		return isCorrectFirstCoord && isCorrectSecondCoord && isCorrectXY;
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
	
	static string ConvertTemperature(double degreeCelsius)
	{
		double degreeFahrenheit = degreeCelsius * 9 / 5 + 32;
		
		return degreeFahrenheit > 100 
			? "Горячо!"
			: degreeFahrenheit < 32 
				? "Холодно!" 
				: "Нейтрально";
	}
	
	static void CalculateInterestRate(double value, double rate, double time)
	{
		double totalValue = Math.Round(value * Math.Pow((1 + rate / 100), time), 2);

		if (totalValue > 1.5 * totalValue)
		{
			Console.WriteLine($"Ваша итоговая суммма составит {totalValue}, Хороший рост!");
		}
		else
		{
			Console.WriteLine($"Ваша суммма составит {totalValue}, Рост умеренный!");
		}
	}

	static string GetDayTime(int time)
	{
		if (time > 23 || time < 0)
		{
			throw new ArgumentOutOfRangeException("Число выходит за пределы 0-23");	
		}

		return (6 <= time && time <= 11) 
			? "Утро" 
			: (12 <= time && time <= 17) 
				? "День" 
				: (18 <= time && time <= 21) 
					? "Вечер" 
					: "Ночь";
	}
}