namespace HomeWorkProcedureProgram;

public class Program
{
    public static void Main(string[] args)
    {
        //Console.WriteLine(string.Join(", ", GetSummaryRange(new int[]{0, 1, 2, 4, 5, 7})));
        //Console.WriteLine(CheckRecord("PPALLPLLLL"));
        //Console.WriteLine(GetMajorityElement(new int[]{3, 2, 3}));
        //Console.WriteLine((BoyerMooreMajorityElement(new []{3, 2, 3})));
        //Console.WriteLine(string.Join(", ", ShiftZeros(new int[]{0, 0, 0, 2, 3})));
        //Console.WriteLine(string.Join(", ", FindAllDisappearedNums(new []{4, 3, 2, 7, 8, 2, 3, 1})));
        //Console.WriteLine(string.Join(", ", FindAllDisappearedNumsUpd(new []{4, 3, 2, 7, 8, 2, 3, 1})));
        Console.WriteLine(CanConstructByMagazine("aa", "aab"));
        Console.WriteLine(CanConstructByMagazineUpd("aa", "aabf"));
        
        /*
        try
        {
            Console.WriteLine(string.Join(", ", GetPascalTriangleRow(3)));

        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
        */
        /*
        try
        {
            int[][] pascalTriangle = GeneratePascalTriangle(6);
        
            foreach (int[] row in pascalTriangle)
            {
                foreach (int number in row)
                {
                    Console.Write($"{number} \t");
                }
                Console.WriteLine();
            }
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
        */

    }
    
    //Задача 1
    /*
    public static int[][] GeneratePascalTriangle(int numRows)
    {
        if (numRows <= 0)
        {
            throw new ArgumentException("The number must be greater than 0");
        }
        
        int[][] pascalTriangle = new int[numRows][];
        pascalTriangle[0] = [1];
        
        if (numRows > 1)
        {
            pascalTriangle[1] = [1, 1];
        }

        for (int i = 2; i < pascalTriangle.Length; i++)
        {
            pascalTriangle[i] = new int[i + 1];
            pascalTriangle[i][0] = 1;
            pascalTriangle[i][i] = 1;
            
            for (int j = 1; j < pascalTriangle[i].Length - 1; j++)
            {
                pascalTriangle[i][j] = pascalTriangle[i - 1][j - 1] + pascalTriangle[i - 1][j];
            }
        }

        return pascalTriangle;
    }
    */
    
    //Задача 2
    public static int[] GetPascalTriangleRow(int rowIndex)
    {
        if (rowIndex <= 0)
        {
            throw new ArgumentException("The number must be greater than 0");
        }
        
        int[][] pascalTriangle = new int[rowIndex + 1][];

        pascalTriangle[0] = [1];

        if (rowIndex > 1)
        {
            pascalTriangle[1] = [1, 1];    
        }

        for (int i = 2; i < pascalTriangle.Length; i++)
        {
            pascalTriangle[i] = new int[i + 1];
            pascalTriangle[i][0] = 1;
            pascalTriangle[i][i] = 1;
            
            for (int j = 1; j < pascalTriangle[i].Length - 1 ; j++)
            {
                pascalTriangle[i][j] = pascalTriangle[i - 1][j - 1] + pascalTriangle[i - 1][j];
            }
        }

        return pascalTriangle[rowIndex];
    }

    //Задача 3
    public static int GetMajorityElement(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            bool swipped = false;
            
            for (int j = 0; j < nums.Length - i - 1; j++)
            {
                if (nums[j] > nums[j + 1])
                {
                    (nums[j], nums[j + 1]) = (nums[j + 1], nums[j]);
                    swipped = true;
                }
            }

            if (!swipped)
            {
                break;
            }
        }

        return nums[nums.Length / 2];
    }
    //Задача 3 (Алгоритм Бойера-Мура)
    public static int BoyerMooreMajorityElement(int[] nums)
    {
        int candidate = 0;
        int count = 0;

        foreach (int num in nums)
        {
            if (count == 0)
            {
                candidate = num;
            }

            count += (candidate == num) ? 1 : -1;
        }
        //необязательная проверка по условию задачи т.к. основной элемент всегда существует
        count = 0;
        foreach (int num in nums)
        {
            if (num == candidate)
            {
                count++;
            }
        }

        return count > nums.Length / 2 ? candidate : -1;
    }
    
    //Задача 11
    public static bool CheckRecord(string record)
    {
        int countAbsence = 0;

        for (int i = 0; i < record.Length; i++)
        {
            if (record[i] == 'A')
            {
                countAbsence++;

                if (countAbsence > 1)
                {
                    return false;
                }
            }

            if (i >= 2 && record[i] == 'L' && record[i - 1] == 'L' && record[i - 2] == 'L')
            {
                return false;
            }
        }

        return true;
    }
    
    // Задача 4. Решение задачи через объявление строки
    public static string[] GetSummaryRange(int[] numberArr)
    {
        if (numberArr.Length == 0)
        {
            return new string[0];
        }
        string range = numberArr[0].ToString();
		
        for (int i = 0; i < numberArr.Length - 1; i++)
        {
            if (numberArr[i + 1] == numberArr[i] + 1)
            {
                continue;
            }

            range = range == numberArr[i].ToString() 
                ? $"{range},  {numberArr[i + 1].ToString()}" 
                : $"{range} -> {numberArr[i].ToString()},  {numberArr[i + 1].ToString()}";
        }
		
        if (range[^1].ToString() != numberArr[^1].ToString())
        {
            range = $"{range} -> {numberArr[^1]}";
        }
        
        string[] summaryRange = range.Split(", ");
        
        return summaryRange;
    }
    
    // Задача 4. Решение задачи альтернативным способом
    /*
    public static string[] GetSummaryRange(int[] numberArr)
    {
        string range = "";
        int start = numberArr[0];

        for (int i = 0; i < numberArr.Length; i++)
        {
            if (i == numberArr.Length - 1 || numberArr[i + 1] != numberArr[i] + 1)
            {
                if (start == numberArr[i])
                {
                    range += start.ToString() + ", ";
                }
                else
                {
                    range += start.ToString() + "->" + numberArr[i].ToString() + ", ";
                }

                if (i != numberArr.Length - 1)
                {
                    start = numberArr[i + 1];
                }
            }
        }
        return range.TrimEnd(',', ' ').Split(", ");;
    }
    */
    /*
    (метод ShiftZeros)Учитывая целочисленный массив nums, переместите все нули в его конец, 
    сохраняя относительный порядок ненулевых элементов. 
    Обратите внимание, что вы должны сделать это на месте, не создавая копию массива.
    */
    //Задача 5 (неоптимальное решение задачи)
    /*
    public static int[] ShiftZeros(int[] nums) //0, 0, 0, 2, 3
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == 0)
                {
                    (nums[i], nums[j]) = (nums[j], nums[i]);
                }
            }
        }
        return nums;
    }
    */
    //Задача 5 (оптимальное решение задачи с применением двух указателей)
    public static int[] ShiftZeros(int[] nums)
    {
        int zeroIndex = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                (nums[i], nums[zeroIndex]) = (nums[zeroIndex], nums[i]);

                zeroIndex++;
            }
        }

        return nums;
    }
    /*
    (метод FindAllDisappearedNums). Учитывая массив nums из n целых чисел,
    где nums[i] находится в диапазоне [1, n],
    верните массив всех целых чисел в диапазоне [1, n], которые не отображаются в nums.
     */
    //Задача 6
    public static int[] FindAllDisappearedNums(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            bool swapped = false;
            
            for (int j = 0; j < nums.Length - i - 1; j++)
            {
                if (nums[j] > nums[j + 1])
                {
                    (nums[j], nums[j + 1]) = (nums[j + 1], nums[j]);
                    swapped = true;
                }
            }

            if (!swapped)
            {
                break;
            }
        }
        Console.WriteLine(string.Join(", ", nums));
        
        int range = 0;
        int start = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] + 1 != nums[i + 1] && nums[i] != nums[i + 1])
            {
                start = nums[i] + 1;
                range = nums[i + 1] - nums[i] - 1;
                break;
            }
        }

        int[] disappearedNumsArr = new int[range];

        for (int i = 0; i < disappearedNumsArr.Length; i++)
        {
            disappearedNumsArr[i] = start++;
        }

        return disappearedNumsArr;
    }
    
    //Задача 6. Оптимальное решение 
    public static int[] FindAllDisappearedNumsUpd(int[] nums) //4, 3, 2, 7, 8, 2, 3, 1
    {
        for (int i = 0; i < nums.Length; i++)
        {
            int index = Math.Abs(nums[i]) - 1;
            nums[index] = -Math.Abs(nums[index]);
        }

        int missingCount = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                missingCount++;
            }
        }

        int[] result = new int[missingCount];
        int idx = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                result[idx] = i + 1;
                idx++;
            }
        }

        return result;
    }
    
    //Задача 7
    public static bool CanConstructByMagazine(string ransomNote, string magazine)
    {
        int count = 0;
        
        for (int i = 0; i < ransomNote.Length; i++)
        {
            if (magazine.Contains(ransomNote[i]))
            {
                int index = magazine.IndexOf(ransomNote[i], 0);
                magazine = magazine.Remove(index, 1);
                count++;
            }
        }

        return count == ransomNote.Length;
    }
    
    //Задача 7 Оптимальное решение
    public static bool CanConstructByMagazineUpd(string ransomNote, string magazine)
    {
        int[] charCounts = new int[26];
        
        foreach (char c in magazine)
        {
            charCounts[c - 'a']++;
            Console.WriteLine(string.Join(", ", charCounts));
        }
        
        foreach (char c in ransomNote)
        {
            if (charCounts[c - 'a'] == 0)
            {
                return false;
            }

            charCounts[c - 'a']--;
        }

        return true;
    }
}