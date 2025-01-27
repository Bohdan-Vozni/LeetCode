using System.Globalization;
using System.Xml;

namespace Remove_Duplicates_from_Sorted_Array
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int past  = nums[0];

            int j = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (past != nums[i] )
                {
                    nums[j] = nums[i];
                    past = nums[j];
                    j++;
                }            
            }
          
            return j ;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution ();

            int[] nums = [1, 1, 1, 2, 2, 2, 3, 4, 5];
            int[] expectNums = [1, 2, 3, 4, 5];
            int k = sol.RemoveDuplicates (nums);

            for (int i = 0; i < k; i++)
            {
                if (nums[i] != expectNums[i])
                {
                    Console.WriteLine("Error");
                    return;
                }
            }

        }
    }
}
