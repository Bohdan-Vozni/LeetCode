namespace Search_Insert_Position
{
    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            int size = nums.Length;


            int right = size - 1;
            int left = 0;

            while (right >= left)
            {
                int middle = left + (right - left) / 2;

                if (nums[middle] == target) return middle;

                if (nums[middle] < target)
                {
                    left = middle + 1;

                }

                if (nums[middle] > target)
                {
                    right = middle - 1;                    
                }

            }

            return right + 1;
        }
    }

    internal class Program
    {


        static void Main(string[] args)
        {
            var sol = new Solution();

            Console.WriteLine( sol.SearchInsert([2,4,6], 7) );
        }
    }
}
