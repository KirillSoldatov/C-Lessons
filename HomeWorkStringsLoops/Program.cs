namespace HomeWorkStringsLoops;

class Program
{
    static void Main(string[] args)
    {
		
		Random rnd = new Random();
		int randomValue = rnd.Next(1, 101);
		/*
		CheckUserNumber(randomValue);
		
		GetPrimeNumbers(20);
		
		GetMedianTemperature();
		
		GetDivisionRemainder();
		
		GetStraight();
		
		GetVowelLetters();
		*/
		GetString();
		
		CheckUserEmail(" k soldatov,19.94 @gmail,com ");
      
		BadWordCheck("я пошел гулять и встретил друга по имени балда дурак");
    }
	
	static void CheckUserNumber(int randomValue)
	{	
		bool isUserGuess = false;
		
		while(!isUserGuess)
		{	
			Console.Write("Введите целое число от 1 до 100: ");
			
			string input = Console.ReadLine();
			int userValue;
			
			if (!int.TryParse(input, out userValue) || userValue < 1 || userValue > 100)
			{
				Console.WriteLine("Ошибка! Введите корректное целое число от 1 до 100.");
				continue;
			}
	
			if (userValue > randomValue)
			{
				Console.WriteLine("Число больше");
			}
			else if (userValue < randomValue)
			{
				Console.WriteLine("Число меньше");
			}
			else
			{
				isUserGuess = true;
				Console.WriteLine("Поздравляю, вы угадали число!");
			}
		}
	}
	
	static void GetPrimeNumbers(int userNumber)
	{	
		for (int i = 2; i <= userNumber; i++)
		{
			bool isPrime = true;
			
			for (int j = 2; j < i; j++)
			{
				if (i % j == 0)
				{
					isPrime = false;
					break;
				}
			}
			
			if (isPrime)
			{
				Console.Write($"{i}, ");
			}
		}
	}
	
	static void GetMedianTemperature()
	{
		int[] dataTemperature = [-5, 0, 3, -2, 4, -1, 6];
		
		for (int i = 0; i < dataTemperature.Length - 1; i++)
		{
			bool swapped = false;
			
			for (int j = 0; j < dataTemperature.Length - i - 1; j++)
			{
				if (dataTemperature[j] > dataTemperature[j + 1])
				{
					int temp = dataTemperature[j];
					dataTemperature[j] = dataTemperature[j + 1];		
					dataTemperature[j + 1] = temp;
					swapped = true;
				}
			}
			
			if (!swapped)
			{
				break;
			}
		}
		
		int mid = dataTemperature.Length / 2;
		double median = dataTemperature.Length % 2 == 0
			? (dataTemperature[mid] + dataTemperature[mid - 1]) / 2.0
			: dataTemperature[mid];
			
		Console.WriteLine(median);
	}
	
	static void GetDivisionRemainder()
	{
		int[] numbersArr = new int[100];
		int divider = 3;
		
		for (int i = 0; i < numbersArr.Length; i++)
		{
			numbersArr[i] = i + 1;
		}
		
		int j = 0;
		
		while(j < numbersArr.Length)
		{
			if (numbersArr[j] % 3 == 0 && numbersArr[j] % 5 == 0)
			{
				int k = j + 1;
				
				while (j < numbersArr.Length)
				{
					if (Math.Abs((numbersArr[j] % divider) - (numbersArr[k] % divider)) % 2 == 0)
					{
						Console.WriteLine(numbersArr[j]);
						break;
					}
					k++;
				}
			}
			j++;
		}
	}
	
	static void GetStraight()
	{
		var lineEquations = new (int, int, int)[]
		{
			(1, 2, 3),
			(4, 5, 6),
			(7, 8, 9),
			(10, 11, 12),
		};
		
		foreach (var line in lineEquations)
		{
			int straight = line.Item1 + line.Item2 + line.Item3;
			Console.WriteLine(straight);
		}
	}
	
	static void  GetVowelLetters()
	{
		string userInput = "abcREfg";
		char[] vowelLetters = new char[]{'a', 'e', 'i', 'o', 'u'};
		
		int i = 0;
		
		foreach (char letter in vowelLetters)
		{
			if (userInput.ToLower().Contains(letter))
			{
				++i;
			}
		}
		
		Console.WriteLine(i);
	}
	
	static void GetString()
	{
		string userInput = "aaaafweeverrrrrgfdb";
		char[] userCharArr = userInput.ToCharArray();
		
		int index = 0;
		
		string resultString = "";
		
		for (int i = 0; i < userCharArr.Length; i++)
		{
			int j = 0;
			
			for (; j < i; j++)
			{
				if (userCharArr[i] == userCharArr[j])
				{
					break;
				}
			}
			
			if (i == j)
			{
				resultString += userCharArr[i];
			}
		}
		
		Console.WriteLine(resultString);
	}
	
	static void CheckUserEmail(string userEmail)
	{
		userEmail = userEmail.Trim().ToLower().Replace(',', '.');

		char[] userEmailToChar = userEmail.ToCharArray();

		int index = 0;

		string cleanedUserEmail = "";

		for (int i = 0; i < userEmailToChar.Length; i++)
		{
			if (userEmailToChar[i] == ' ')
			{
				continue;
			}

		cleanedUserEmail += userEmailToChar[i];
		}

		Console.WriteLine(cleanedUserEmail);
	}
	
	static void BadWordCheck(string userText)
	{
		int counter = 0;

		var excludes = new[] {"дурак", "балда", "глупый"};

		foreach(var word in excludes)
		{
			if (userText.Contains(word))
			{
			userText = userText.Replace(word, "***");
			++counter;
			}
		}

		if (counter == 3)
		{
			userText = "Администрация решила скрыть данное сообщение";
		}

		Console.WriteLine(userText);

	}
}
