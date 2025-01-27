using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Substring_Without_Repeating_Characters
{
    internal class Other_Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            if(string.IsNullOrEmpty(s)) return 0;

            HashSet<char> unicqueChars = new HashSet<char>();
            int maxLength = 0;
            int left = 0;

            for(int right = 0; right < s.Length; right++)
            {
                while (unicqueChars.Contains(s[right]))
                {
                    unicqueChars.Remove(s[left]);
                    left++;
                }

                unicqueChars.Add(s[right]);
                maxLength = Math.Max(maxLength, right - left +1);
            }

            return maxLength;
        }
    }
}
