using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

public class Solution
{
    public int FindSpecialInteger(int[] arr)
    {
        int i = 0;
        int n = arr.Length;
        int count = 1;
        while(i < n-1 && count <= n/4)
        {
            if (arr[i] == arr[i + 1]) count++;
            else count = 0;
            i++;
        }
        return arr[i];
    }
    public int[][] Transpose(int[][] matrix)
    {
        int n = matrix[0].Length ;
        int[][] result = new int[n][];
        for(int i = 0; i < result.Length;i++)
        {
            result[i] = matrix.Select(x  => x[i]).ToArray();
        }
        return result;
    }
    public string LargestOddNumber(string num)
    {
        char[]  odd = { '1', '3', '5', '7', '9' };
        int i = num.Length - 1;
        while(i>=0)
        {
            if (odd.Contains(num[i])) break;
            else i--;    
        }
        if (i == -1) return string.Empty;
        else return num.Remove(++i);
    }
    public int AddTotalMoney(int start, int step)
    {
        return step*(start * 2 + step - 1)/2;
    }
    public int TotalMoney(int n)
    {
        int m = n;
        int start = 1;
        int add = 0;
        while (m > 7)
        {
            add += AddTotalMoney(start, 7);
            start += 1;
            m -= 7;
        }
        if (m == 0) return add;
        else return add + AddTotalMoney(start, m);
    }
    public string LargestGoodInteger(string num)
    {
        char r = '/';
        for(int i=1;i<num.Length;i++)
        {
            if (num[i] == num[i - 1] && num[i] == num[i + 1] && num[i] > r)
            r = (char)num[i];
        }
        if (r <= '9' && r >= '0')
            return (r.ToString() + r.ToString() + r.ToString());
        else return string.Empty;
    }
    public int coinPile(int[] piles)
    {
        int result = 0;
        int count = 0;
        int m = 0;
        int n=piles.Length -1;
        Array.Sort(piles);
        for(;count < piles.Length / 3;count++)
        {
            result += piles[n - 1];
            n -= 2;
        }
        return result;
    }
    public bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        StringBuilder w1 = new StringBuilder();
        StringBuilder w2 = new StringBuilder();
        for(int i=0;i < word1.Length;i++)
        {
            w1.Append(word1[i]);
        }
        for (int i = 0; i < word2.Length; i++)
        {
            w2.Append(word2[i]);
        }
        return (w1.ToString().Equals(w2.ToString()));
    }
    public bool IsUgly(int n)
    {
        if (n <= 0) return false;
        else
        {
            while (n % 2 == 0)
            {
                n /= 2;
            }
            while (n % 3 == 0)
            {
                n /= 3;
            }
            while (n % 5 == 0)
            {
                n /= 5;
            }
            if (n == 1) return true; else return false;
        }
    }
    /*    public IList<IList<int>> Permute(int[] nums) 
            IList < IList<int> > result = new List<IList<int>>();

            return result;
        }*/

    public long ZeroFilledSubarray(int[] nums)
    {
        long result = 0;
        for(int i=0; i<nums.Length; i++)
        {
            long count = 0;
            if (nums[i] == 0)
            {
                count = count + 1;
                Console.WriteLine("s{0}",count );
            }
            else
            {
                result += count * (count + 1) / 2;
                Console.WriteLine(count * (count + 1) / 2);
                count = 0;
            }
        }
        return result;
    }



    public IList<IList<int>> Generate(int numRows)
    {
        IList<IList<int>> result= new List<IList<int>>();
        result[0] = new List<int>(1);
        for(int i = 1; i < numRows;i++)
        {
           result.Add(new List<int>(1));
        }
        for(int i=1; i < numRows;i++)
        {
            for(int j = 1; j < i;j++)
            {
                result[i][j] = result[i - 1][j-1] + result[i - 1][j];
            }    
        }
        return result;
    }
    public int MinCostConnectPoints(int[][] points)
    {
        
        return -1;
    }
    public int[] SortArrayByParity(int[] nums)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 != 0) result.Add(nums[i]);
            else result.Insert(0, nums[i]);
        }
        return result.ToArray();
    }

    public int SingleNumber(int[] nums)
    {
        return nums.Distinct().ToArray()[0];
    }
    public int FindDuplicate(int[] nums)
    {
        int[] alt = new int[nums.Length];
        for(int i=0;i<nums.Length;i++)
        {
            alt[nums[i]] += 1;
        }
        int j = 1;
        while (alt[j] < 2)
        {
            j++;
        }
        return j;
    }

    public bool WinnerOfGame(string colors)
    {
        List<char> chars = new List<char>();
        chars.AddRange(colors);
        int point = 0;
        for(int i=1;i<chars.Count-1;i++)
        {
            if (chars[i] == 'A' && chars[i - 1] == 'A' && chars[i + 1] == 'A') point++;
            if (chars[i] == 'B' && chars[i - 1] == 'B' && chars[i + 1] == 'B') point--;
        }
        return point > 0;
    }
    public static void Main()
    {
        //drive code for ugly 1
        /*        int m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(s.IsUgly(m));*/

        //drive code for SortArrayByParity
        /*Console.Write("Array size:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        for(int i=0;i<n;i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        int[] array2 = solution.SortArrayByParity(array);
        for(int i=0;i<n;i++)
        {
            Console.WriteLine(array2[i]);
        }
    }*/
        /*int n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(  solution.SingleNumber(array));*/
        /*int[] arr = new int[] { 2, 4, 1, 2, 7, 8 };*/
        int[] test = { 1, 1, 1, 1, 1, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 12, 12, 12 };
        Solution solution = new Solution();
        int result = solution.FindSpecialInteger(test);

        Console.WriteLine(result.ToString());
    }
}