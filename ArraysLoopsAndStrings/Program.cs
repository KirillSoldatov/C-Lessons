namespace ArraysLoopsAndStrings;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
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
}
