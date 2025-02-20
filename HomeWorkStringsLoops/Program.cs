namespace HomeWorkStringsLoops;

class Program
{
    static void Main(string[] args)
    {
		/*
		CheckUserNumber(53);
		
		GetPrimeNumbers(20);
		
		int[] dataTemperature = {-5, 0, 3, -2, 4, -1, 6};
		Console.WriteLine(GetMedianTemperature(dataTemperature));
		
		GetDivisionRemainder();
		
		var lineEquations = new (int, int, int)[]
		{
			(1, 2, 3),
			(4, 5, 6),
			(7, 8, 9),
			(10, 11, 12),
		};
		
		int[] straightResult = GetStraight(lineEquations);
		
		Console.WriteLine(string.Join(", ", straightResult));
		
		Console.WriteLine(GetNumberOfVowels(userInput));
		
		string userInput = "abcREffffffgggggg";
		
		Console.WriteLine(GetString(userInput));
		
		string userEmail = " k soldatov,19.94 @gmail,com ";
		Console.WriteLine(GetCleanedUserEmail(userEmail));
		*/
		string userText = "я пошел гулять и встретил друга по имени балда дурак балда глупый";
		bool isBadWords = BadWordCheck(userText, out string censoredText);
		
		Console.WriteLine(isBadWords);
		Console.WriteLine(censoredText);
    }
	
	static int CheckUserInput()
	{
		int userValue;
		
		while (true)
		{
			Console.Write("Введите целое число от 1 до 100: ");
			
			string input = Console.ReadLine();
			
			if (int.TryParse(input, out userValue))
			{
				return userValue;
			}
			else
			{
				Console.WriteLine("Значение неверно, введите корректное значение");
			}
		}
	}
	
	//в оптимистичном сценарии при бинарном поиске количество итераций будет O(log N)
	static void CheckUserNumber(int randomValue)
	{	
		bool isUserGuess = false;
		
		while(!isUserGuess)
		{	
			int userValue = CheckUserInput();
	
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
	
	//O(N-2) * O(1) * O(((N+1)/2)-2) *O(1) = O(N) * O(N) = O(N^2). Корректировка - O(N-2) + O(N^2) + O(1) = O(N^2)
	static void GetPrimeNumbers(int userNumber)
	{	
		for (int i = 2; i <= userNumber; i++) // N-2
		{
			bool isPrime = true;
			
			for (int j = 2; j < i; j++) //((N+1)/2)-2. Корректировка : (i-2) = N(N+1)/2 => O(N^2)
			{
				if (i % j == 0) //O(1)
				{
					isPrime = false;
					break;
				}
			}
			
			if (isPrime) //O(1)
			{
				Console.Write($"{i}, ");
			}
		}
	}
	
	//O(1)+O(N)*O(N)*O(1)=O(N^2+1)=O(N^2). Корректировка : O(N) + O(N^2) + O(1) + O(1) = O(N^2)
	static double GetMedianTemperature(int[] dataTemperature)
	{
		for (int i = 0; i < dataTemperature.Length - 1; i++) //O(N-1) => O(N)
		{
			bool swapped = false;
			
			for (int j = 0; j < dataTemperature.Length - i - 1; j++) //O(((N+1)/2)-1) => O(N). Корректировка : (N-i-1) = N(N+1)/2 => O(N^2)
			{
				if (dataTemperature[j] > dataTemperature[j + 1]) // O(2) => O(1)
				{
					(dataTemperature[j], dataTemperature[j + 1]) = (dataTemperature[j + 1], dataTemperature[j]); // O(1)
					swapped = true;
				}
			}
			
			if (!swapped) //O(1)
			{
				break;
			}
		}
		
		int mid = dataTemperature.Length / 2;
		
		return dataTemperature.Length % 2 == 0
			? (dataTemperature[mid] + dataTemperature[mid - 1]) / 2.0
			: dataTemperature[mid];
	}
	
	//O(1) + O(N)*O(1)*O(1) + O(1) = O(N)
	static int GetDivisionRemainder(int[] numbersArr)
	{
		int j = 0; // O(1)
		
		while(j < numbersArr.Length) //O(N)
		{
			if (numbersArr[j] % 3 == 0 && numbersArr[j] % 5 == 0) //O(1)
			{
				j++;//O(1)
			}
		}
		
		return j; //O(1)
	}
	
	//O(N) * O(1) = O(N)
	static int[] GetStraight((int k, int x, int b)[] lineEquations)
	{
		int[] straightLineArr = new int[lineEquations.Length];
		
		int i = 0;
		
		foreach (var line in lineEquations) //O(N)
		{
			int straight = line.k * line.x + line.b; //O(2) => O(1)
			straightLineArr[i] = straight;
			i++;
		}
		
		return straightLineArr;
	}
	
	//O(1) + O(N)*(O(N) + O(1)) = O(N^2)
	static int GetNumberOfVowels(string userInput)
	{
		char[] vowelLetters = new char[]{'a', 'e', 'i', 'o', 'u'};
		
		int i = 0;
		
		string lowerUserInput = userInput.ToLower(); //O(N)
		
		foreach (char letter in vowelLetters) //O(N)
		{
			if (lowerUserInput.Contains(letter)) //O(N)
			{
				++i; //O(1)
			}
		}
		
		return i;
	}
	
	//O(1) + O(N) + O(N^2) + O(N^2) = O(N^2)
	static string GetString(string userInput)
	{
		char[] userCharArr = userInput.ToCharArray(); //O(1)
		
		string resultString = ""; //O(1)
		
		for (int i = 0; i < userCharArr.Length; i++) //O(N)
		{
			int j = 0; //O(1)
			
			for (; j < i; j++) //(N-i) = N(N-1)/2 => O(N^2)
			{
				if (userCharArr[i] == userCharArr[j])//O(1)
				{
					break;
				}
			}
			
			if (i == j) //O(1)
			{
				resultString += userCharArr[i];//O(N^2)
			}
		}
		
		return resultString; //O(1)
	}
	
	//O(N) + O(N) + O(N) + O(N) + O(1) + O(1) + O(N) + O(N^2) + O(1) = O(N^2)
	static string GetCleanedUserEmail(string userEmail)
	{
		return userEmail.Trim().Replace(" ","").ToLower().Replace(',', '.'); //O(N) + O(N) + O(N)
	}
	
	//O(1) + O(1) + O(1) * (O(N) + O(N) + O(1)) + O(1) = O(N)
	static bool BadWordCheck(string userText, out string censoredText)
	{
		bool isBadWords = false; //O(1)
		censoredText = userText; //O(1)
		int counter = 0; //O(1)

		var excludes = new[] {"дурак", "балда", "глупый"}; //O(1)

		foreach(var word in excludes) //O(1)
		{
			if (userText.Contains(word)) //O(N)
			{
				censoredText = censoredText.Replace(word, "***"); //O(N)
				++counter; //O(1)
				isBadWords = true; //O(1)
			}
		}

		if (counter == 3) //O(1)
		{
			censoredText = "Администрация решила скрыть данное сообщение"; //O(1)
		}

		return isBadWords; //O(1)
	}
}
