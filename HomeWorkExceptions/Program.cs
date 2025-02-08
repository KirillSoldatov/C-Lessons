namespace HomeWorkExceptions;

class Program
{
	public static void Main(string[] args)
	{
		try
		{
			Console.WriteLine(SafeSum(long.MaxValue, double.MaxValue));
		}
		catch (OverflowException)
		{
			Console.WriteLine("The value is beyond long");     
		}
		/*
		try
		{
			Console.WriteLine(RoundAndCheck(double.MaxValue));
		}
		catch (OverflowException)
		{
			Console.WriteLine("The value is beyond int");
		}

		try
		{
			Console.WriteLine(Divide(5, 0));
		}
		catch (ArgumentException)
		{
			Console.WriteLine("It is not allowed to divide by zero");
		}
		*/
	}
	
	static double Divide(int firstNumber, double secondNumber)
	{   
		return secondNumber == 0 ? throw new  ArgumentException() : firstNumber / secondNumber; 
	}

	static int RoundAndCheck(double value)
	{
		int result = checked((int)value);
		
		return value - result < 0.5 ? result : ++result;
	}

	static long SafeSum(long firstNumber, double secondNumber)
	{
		long toLong = checked((long)secondNumber);
		
		return firstNumber + toLong <= long.MaxValue ? firstNumber + toLong : throw new OverflowException();
	}
}
