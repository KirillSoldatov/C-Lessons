namespace CheckPointProcedureProgramming;


public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(string.Join(", ", GetSummaryRanges(new int[]{0,2,3,4})));
    }
	
	/*
	(метод GetSummaryRanges) Вам предоставляется отсортированный уникальный целочисленный массив nums. Диапазон [a,b] - это набор всех целых чисел от a до b (включительно). 
	Возвращает наименьший отсортированный список диапазонов, которые точно охватывают все числа в массиве. 
	То есть каждый элемент nums покрывается ровно одним из диапазонов, и нет такого целого числа x, которое находилось бы в одном из диапазонов, но не в nums. 
	Каждый диапазон [a,b] в списке должен быть выведен в виде:
	"a->b" if a != b
	"a" if a == b

	Пример: 
	Input: nums = [0,1,2,4,5,7]
	Output: ["0->2","4->5","7"]

	Ограничения:
	0 <= nums.length <= 20
	-231 <= nums[i] <= 231 - 1
	Все значения nums уникальны.
	Числа сортируются в порядке возрастания.
	*/
	
	public static string[] GetSummaryRanges(int[] nums) //[0,1,2,4,5,7] [0,2,3,4]
	{
		int count = 1;
		
		for (int i = 0; i < nums.Length - 1; i++)
		{
			if (nums[i + 1] == nums[i] + 1)
			{
				continue;
			}
			
			count++; //3
		}
		
		string[] summaryRangesArr = new string[count];
		int j = 0;
		summaryRangesArr[j] = nums[0].ToString(); //["0", "2"]
													//[0,2,3,4]
		
		for (int i = 0; i < nums.Length - 1; i++)
		{	
			if (nums[i + 1] == nums[i] + 1) //i = 2; i = 4
			{
				continue;
			}
			
			summaryRangesArr[j] = nums[i].ToString() == summaryRangesArr[j] 
				? summaryRangesArr[j] 
				: summaryRangesArr[j] + "->" + nums[i].ToString();

			j++;
			summaryRangesArr[j] = nums[i + 1].ToString();
		}
		
		if (nums[^1].ToString() != summaryRangesArr[^1])
		{
			summaryRangesArr[^1] += "->" + nums[^1].ToString();
		}
		
		return summaryRangesArr;
	}
	
}
