namespace ArraysLoopsAndStrings;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(CheckPrimeDividers(729));
    }
	
	static ulong GetFactorial(ulong N)
	{
		if (N == 1)
		{
			return 1;
		}
		return N * GetFactorial(N - 1);
	}
	
	// Содержит ли число только простые делители 3 или 5 - Задача
	static bool CheckPrimeDividers(int value)
	{	
		if (value == 1)
		{
			return true;
		}
		
		if (value % 3 == 0)
		{
			return CheckPrimeDividers(value / 3);
		}
		else if (value % 5 == 0)
		{
			return CheckPrimeDividers(value / 5);
		}
		else
		{
			return false;
		}
	}
	
}
