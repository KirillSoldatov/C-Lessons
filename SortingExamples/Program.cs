namespace SortingExamples;

class Program
{
    static void Main(string[] args)
    {
		//int[] arr = {5, 2, 9, 7, 3, 8, 10};
		//BubbleSort(arr);
		//ShakerSort(arr);
        //Console.WriteLine(string.Join(", ", arr));
		//BubbleSortSecondVersion(arr);
		//ShakerSortSecondVersion(arr);
		//CombSort(arr);
		//InserionSort(arr);
		//Console.WriteLine(string.Join(", ", arr));
		
		//Console.WriteLine(GetFrogWaysCount(10));
		int[,] wayMap = { {0, 1, 2, 4, 5, 6}, {3, 4, 5, 6, 7, 8}, {3, 4, 5, 1, 2, 3} };
		
		
		//Console.WriteLine(GetShortDistance(new int[]{5, 2, 9, 7, 3, 8, 10}));
		Console.WriteLine(GetShortDistanceDog(wayMap));
    }
	//O(N^2)
	static void BubbleSort(int[] arrInput)
	{
		for (int i = 0; i < arrInput.Length; i++)
		{
			for (int j = i + 1; j < arrInput.Length; j++)
			{
				if (arrInput[i] > arrInput[j])
				{
					(arrInput[i], arrInput[j]) = (arrInput[j], arrInput[i]);
				}
			}
		}
	}
	
	static void ShakerSort(int[] arrInput)
	{
		int begin = 0;
		int end = arrInput.Length;
		bool isEnd;
		
		do
		{
			for (int i = begin; i < end - 1 ; i++)
			{
				if (arrInput[i] > arrInput[i + 1])
				{
					(arrInput[i], arrInput[i + 1]) = (arrInput[i + 1], arrInput[i]);
				}
			}
			end--;
			
			for (int i = end; i >= begin + 1; i--)
			{
				if (arrInput[i] < arrInput[i - 1])
				{
					(arrInput[i], arrInput[i - 1]) = (arrInput[i - 1], arrInput[i]);
				}
			}
			begin++;
			
			isEnd = end - begin <= 1;
		}
		while (!isEnd);
	}
	
	static void BubbleSortSecondVersion(int[] initialArr)
	{
		for (int i = 0; i < initialArr.Length; i++)
		{
			bool swapped = false;
			
			for (int j = 0; j < initialArr.Length - i - 1; j++)
			{
				if (initialArr[j] > initialArr[j + 1])
				{
					(initialArr[j], initialArr[j + 1]) = (initialArr[j + 1], initialArr[j]);
					swapped = true;
				}
			}
			
			if (!swapped)
			{
				break;
			}
		}
	}
	
	static void ShakerSortSecondVersion(int[] initialArr)
	{
		for (int i = 0; i < initialArr.Length / 2; i++)
		{
			bool swapped = false;
			
			for (int j = 0; j < initialArr.Length - i - 1; j++)
			{
				if (initialArr[j] > initialArr[j + 1])
				{
					(initialArr[j], initialArr[j + 1]) = (initialArr[j + 1], initialArr[j]);
					swapped = true;
				}
			}
			
			for (int k = initialArr.Length - i - 2; k >= i; k--)
			{
				if (initialArr[k] < initialArr[k - 1])
				{
					(initialArr[k], initialArr[k - 1]) = (initialArr[k - 1], initialArr[k]);
					swapped = true;
				}
			}
			
			if (!swapped)
			{
				break;
			}
		}
	}
	
	static void CombSort(int[] initialArr)
	{
		double shrink = 1.3;
		int gap = initialArr.Length;
		bool swapped;
		
		do
		{
			gap = (int)(gap / shrink);
			swapped = false;

			for (int i = 0; i + gap < initialArr.Length; i++)
			{
					if (initialArr[i] > initialArr[i + gap])
					{
						(initialArr[i], initialArr[i + gap]) = (initialArr[i + gap], initialArr[i]);
						swapped = true;
					}
			}
		}
		while(gap > 1 || swapped);
	}
	
	static void InserionSort(int[] initialArr)
	{
		for (int i = 1; i < initialArr.Length; i++)
		{
			int temp = initialArr[i];
			
			int j = i - 1;
			
			while (j >= 0 && initialArr[j] > temp)
			{
				initialArr[j + 1] = initialArr[j];
				j--;
			}
			
			initialArr[j + 1] = temp;
		}
	}
	
	static int GetFrogWaysCount(int grasshopperDestination)
	{
		int[] wayMap = new int[grasshopperDestination];
		
		wayMap[0] = 1;
		wayMap[1] = 1;
		
		if (grasshopperDestination <= 1)
		{
			return 1;
		}
		
		for (int i = 2; i < grasshopperDestination; i++)
		{
			wayMap[i] = wayMap[i - 1] + wayMap[i - 2];
		}
		
		return wayMap[^1];
	}
	
	static int GetShortDistance(int[] wayMap)
	{
		if (wayMap.Length == 0)
		{
			return 0;
		}
		
		if (wayMap.Length == 1)
		{
			return wayMap[0];
		}
		
		if (wayMap.Length == 2)
		{
			return Math.Min(wayMap[0], wayMap[1]);
		}
		
		for (int i = 2; i < wayMap.Length; i++)
		{
			wayMap[i] += Math.Min(wayMap[i - 1], wayMap[i - 2]);
		}
		
		return wayMap[^1];
	}
	
	static int GetShortDistanceDog(int[,] wayMap)
	{
		int row = wayMap.GetUpperBound(0);
		int column = wayMap.GetUpperBound(1);
		
		for (int i = 0; i <= row; i++)
		{
			for (int j = 0; j <= column; j++)
			{
				if (i == 0 && j == 0)
				{
					continue;
				}
				
				if (j == 0)
				{
					wayMap[i, j] += wayMap[i - 1, j];
					continue;
				}
			
				if (i == 0)
				{
					wayMap[i, j] += wayMap[i, j - 1];
					continue;
				}
				
				wayMap[i, j] += Math.Min(wayMap[i - 1, j], wayMap[i, j - 1]); 
			}
		}
		return wayMap[row, column];
	}
}
