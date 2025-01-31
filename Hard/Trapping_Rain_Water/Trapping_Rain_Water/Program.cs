using Microsoft.VisualBasic.FileIO;
using System.ComponentModel.Design;

namespace Trapping_Rain_Water
{
    public class Solution
    {
        public int Trap(int[] height)
        {
            int max = 0;
            for (int i = 0; i < height.Length; i++)
            {
                if (height[i] > max)
                {
                    max = height[i];
                    
                }
            }
            int waterResult = 0;

            for (int i = 1; i <= max; i++)
            {
                int checkEdge = 0;
                

                for (int j = 0; j < height.Length; j++)
                {

                    if (height[j] >= i )
                    {
                        checkEdge = j + 1;                        
                    }
                    else if (checkEdge != 0)
                    {
                        int count = 0;

                        for (int k = j; k < height.Length && height[k] < i; k++)
                        {
                            count++;
                            if (k == height.Length - 1) count -= count;
                            j = k;
                        }
                        waterResult += count;
                        checkEdge = 0;
                    }
                    
                }

            }

            return waterResult;
        }

        public int Trap1(int[] height)
        {
            if (height == null || height.Length == 0)
                return 0;

            int left = 0, right = height.Length - 1;
            int leftMax = 0, rightMax = 0;
            int trappedWater = 0;

            while (left < right)
            {
                if (height[left] < height[right])
                {
                    if (height[left] >= leftMax)
                        leftMax = height[left];
                    else
                        trappedWater += leftMax - height[left];

                    left++;
                }
                else
                {
                    if (height[right] >= rightMax)
                        rightMax = height[right];
                    else
                        trappedWater += rightMax - height[right];

                    right--;
                }
            }

            return trappedWater;
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            var sol = new Solution();

            int result = sol.Trap1([0,1,0,2,1,0,1,3,2,1,2,1]);
            Console.WriteLine(result);
        }
    }
}
