namespace HomeWorkArraysLoops;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine(RomanToInt("III"));
	}
	
	//O(N)
	static int RomanToInt(string s)
	{
		char[] romanValue = s.ToCharArray();
		int intValue = 0;
		
		for (int i = 0; i < romanValue.Length; i++) //O(N)
		{
			if (i + 1 < romanValue.Length) //O(1)
			{
				int doubleValue = CheckDoubleRomanValue((romanValue[i], romanValue[i + 1])); //O(1)
				if (doubleValue > 0)
				{
					intValue += doubleValue;
					i++;
					continue;
				}
			}
			
			intValue += CheckSingleRomanValue(romanValue[i]); //O(N)
		}
		
		return intValue;
	}
	
	static int CheckDoubleRomanValue((char firstValue, char secondValue) doubleRomanValue)
	{
		if (doubleRomanValue.firstValue == 'I' && doubleRomanValue.secondValue == 'V')
		{
			return 4;
		}

		if (doubleRomanValue.firstValue == 'I' && doubleRomanValue.secondValue == 'X')
		{
			return 9;
		}

		if (doubleRomanValue.firstValue == 'X' && doubleRomanValue.secondValue == 'L')
		{
			return 40;
		}

		if (doubleRomanValue.firstValue == 'X' && doubleRomanValue.secondValue == 'C')
		{
			return 90;
		}

		if (doubleRomanValue.firstValue == 'C' && doubleRomanValue.secondValue == 'D')
		{
			return 400;
		}

		if (doubleRomanValue.firstValue == 'C' && doubleRomanValue.secondValue == 'M')
		{
			return 900;
		}
		
		return 0;
	}
	
	static int CheckSingleRomanValue(char singleRomanValue)
	{
		switch(singleRomanValue)
		{
			case 'I':
			return 1;

			case 'V':
			return 5;

			case 'X':
			return 10;  

			case 'L':
			return 50;

			case 'C':
			return 100;

			case 'D':
			return 500;

			case 'M':
			return 1000;               
		}
		
		return 0;
	}
	
	//O(N^2)
	static void Rotate(int[][] matrix) 
	{
		for (int i = 0; i < matrix.Length; i++) //O(N)
		{
			for (int j = i + 1; j < matrix.Length; j++) //O(N*(N+1)/2 => O(N^2)
			{
				(matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]); //O(1)
			}
		}

		for (int i = 0; i < matrix.Length; i++) //O(N)
		{
			for (int j = 0; j < matrix.Length / 2; j++) //O(N/2)
			{
				(matrix[i][j], matrix[i][matrix.Length - 1 - j]) = (matrix[i][matrix.Length - 1 - j], matrix[i][j]); //O(1)
			}
		}
	}
	
	//O(N^2)
	static void MoveZeroes(int[] nums)
	{
		for (int i = 0; i < nums.Length - 1; i++) //O(N-1)
		{
			for (int j = 0; j < nums.Length - 1 - i; j++) //O(N-1-i) => O(N*(N-1)/2) => N^2
			{
				if (nums[j] == 0) //O(1)
				{
					(nums[j], nums[j + 1]) = (nums[j + 1], nums[j]); //O(1)
				}
			}
		}
	}
}
