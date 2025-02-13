namespace HomeWorkArraysLoops;

class Program
{
	static void Main(string[] args)
	{
		
	}
	
	static int RomanToInt(string s)
	{
		char[] romanValue = s.ToCharArray();
		int intValue = 0;
		
		for (int i = 0; i < romanValue.Length; i++)
		{
			if (i + 1 != romanValue.Length)
			{
				if (romanValue[i] == 'I' && romanValue[i + 1] == 'V')
				{
					intValue += 4;
					++i;
					continue;
				}

				if (romanValue[i] == 'I' && romanValue[i + 1] == 'X')
				{
					intValue += 9;
					++i;
					continue;
				}

				if (romanValue[i] == 'X' && romanValue[i + 1] == 'L')
				{
					intValue += 40;
					++i;
					continue;
				}

				if (romanValue[i] == 'X' && romanValue[i + 1] == 'C')
				{
					intValue += 90;
					++i;
					continue;
				}

				if (romanValue[i] == 'C' && romanValue[i + 1] == 'D')
				{
					intValue += 400;
					++i;
					continue;
				}

				if (romanValue[i] == 'C' && romanValue[i + 1] == 'M')
				{
					intValue += 900;
					++i;
					continue;
				}
			}
			
			switch(romanValue[i])
			{
				case 'I':
				intValue += 1;
				break;

				case 'V':
				intValue += 5;
				break;

				case 'X':
				intValue += 10;
				break;    

				case 'L':
				intValue += 50;
				break;

				case 'C':
				intValue += 100;
				break;

				case 'D':
				intValue += 500;
				break;

				case 'M':
				intValue += 1000;
				break;                
			}
		}
		
		return intValue;
	}
	
	static void Rotate(int[][] matrix) 
	{
		for (int i = 0; i < matrix.Length; i++)
		{
			for (int j = i + 1; j < matrix.Length; j++)
			{
			int temp = matrix[i][j];
			matrix[i][j] = matrix[j][i];
			matrix[j][i] = temp;
			}
		}

		for (int i = 0; i < matrix.Length; i++)
		{
			for (int j = 0; j < matrix.Length / 2; j++)
			{
			int temp = matrix[i][j];
			matrix[i][j] = matrix[i][matrix.Length - 1 - j];
			matrix[i][matrix.Length - 1 - j] = temp;
			}
		}
	}

	static void MoveZeroes(int[] nums)
	{
		for (int i = 0; i < nums.Length - 1; i++)
		{
			for (int j = 0; j < nums.Length - 1 - i; j++)
			{
				if (nums[j] == 0)
				{
					int temp = nums[j];
					nums[j] = nums[j + 1];
					nums[j + 1] = temp;
				}
			}
		}
	}
}
