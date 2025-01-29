using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace Median_of_Two_Sorted_Arrays
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int size = nums1.Length + nums2.Length;

            int middle = size / 2;

            int[] result = new int[middle + 1];

            int i = 0, j = 0, k = 0;
            
            while (i < nums1.Length && j < nums2.Length && k <= middle )
            {
                if (nums1[i] < nums2[j])
                {
                    result[k++] = nums1[i++];
                }
                else
                {
                    result[k++] = nums2[j++];
                }
            }

            while ( i < nums1.Length && k <= middle)
            {
                result[k++] = nums1[i++];
            }

            while (j < nums2.Length && k <= middle)
            {
                result[k++] = nums2[j++];
            }

            k--;

            if (size % 2 == 0)
            {
                return (double)(result[k] + result[k-1]) / 2;
            }
            else
            {
                return (double)result[k];
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();

            var result = sol.FindMedianSortedArrays([1,4], [2,3]);
            Console.WriteLine(result);
        }
    }
}
