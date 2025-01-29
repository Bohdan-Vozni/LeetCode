using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Count_and_Say
{
    public class Solution
    {
        public string CountAndSay(int n)
        {
            if (n == 1) return "1"; 

            string str = CountAndSay(n - 1); 

            char past = str[0];
            int count = 0;
            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (past != str[i])
                {
                    result += count.ToString() + past;
                    count = 1;
                    past = str[i];
                }
                else
                {
                    count++;
                }

                if (i == str.Length - 1) 
                {
                    result += count.ToString() + past;
                }
            }

            return result;
        }

        public string CountAndSay1(int n)
        {
            if (n == 1) return "1"; 

            string str = "1"; 

            for (int i = 1; i < n; i++) 
            {
                char past = str[0];
                int count = 0;
                string result = "";

                for (int j = 0; j < str.Length; j++)
                {
                    if (past != str[j]) 
                    {
                        result += count.ToString() + past; 
                        count = 1; 
                        past = str[j];
                    }
                    else
                    {
                        count++; 
                    }
                }

                
                result += count.ToString() + past;

                str = result; 
            }

            return str; 
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();
            string number = sol.CountAndSay(5);
            Console.WriteLine(number);
        }
    }
}
