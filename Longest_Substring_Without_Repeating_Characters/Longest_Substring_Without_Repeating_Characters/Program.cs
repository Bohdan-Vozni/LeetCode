using System.Runtime.ExceptionServices;

namespace Longest_Substring_Without_Repeating_Characters
{
    internal class Program
    {
        public class Solution
        {
            public int LengthOfLongestSubstring(string s)
            {
                string previous = "";

                for (int i = 0; i < s.Length; i++)
                {
                    string current = "";

                    for (int j = i; j < s.Length; j++)
                    {
                        if (!current.Contains(s[j])) current += s[j];
                        else break;
                    }
                    if (previous.Length < current.Length) previous = current;
                }
                return previous.Length;
            }
        }

        static void Main(string[] args)
        {
            var sol = new Solution();
            var othersol = new Other_Solution();

            string str = "aabcdddddddjjjjjjjja";

            int count = sol.LengthOfLongestSubstring(str);
            int othcount = othersol.LengthOfLongestSubstring(str);

            Console.WriteLine(count);
            Console.WriteLine(othcount);
        }
    }
}
