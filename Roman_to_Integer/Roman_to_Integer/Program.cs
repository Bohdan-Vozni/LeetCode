using System.Data;
using System.Xml;

namespace Roman_to_Integer
{
    internal class Program
    {
        public class Solution
        {
            private string[] arrRowNumber =  new string[] {"I", "V", "X", "L", "C", "D", "M"};

            private static Dictionary<string, int> romInt = new Dictionary<string, int>()
            {
                { "I", 1 },
                { "V", 5 },
                { "X", 10 },
                { "L", 50 },
                { "C", 100 },
                { "D", 500 },
                { "M", 1000 }
            };

            public int RomanToInt(string s)
            {
                int result = 0;
                s = s.ToUpper();
                string[] arrRom = s.Select(c => c.ToString()).ToArray();

                // I X C   0 2 4                
                for (int i = 0; i < arrRom.Length; i++)
                {
                    if (arrRom[i] == "I" || arrRom[i] == "X" || arrRom[i] == "C"  )
                    {
                        if (i == arrRom.Length - 1)
                        { 
                            result += romInt[arrRom[i]]; 
                            break;
                        }

                        int sumbolIndex = Array.IndexOf(arrRowNumber, arrRom[i]);

                        if (arrRom[i + 1] == arrRowNumber[sumbolIndex + 1] || arrRom[i + 1] == arrRowNumber[sumbolIndex + 2])
                        {
                            result += romInt[arrRom[i + 1]] - romInt[arrRom[i]];
                            i++;

                        }
                        else
                        {
                            result += romInt[arrRom[i]];
                        }

                    }
                    else
                    {
                        result += romInt[arrRom[i]];
                    }

                }


                return result;
            }
        }
        static void Main(string[] args)
        {
            var number = new Solution();

            Console.WriteLine( number.RomanToInt("mcmxcivi"));
        }
    }
}
