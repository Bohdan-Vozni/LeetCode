namespace Reverse_Integer
{
    public class Solution
    {
        public int Reverse1 (int x)
        {
            string revers = new string(x.ToString().Where(x => x != '-').Reverse().ToArray() );

            double result = x < 0 ? double.Parse(revers) * -1 : double.Parse(revers);

           
             
            return (int)result;
        }

        public int Reverse (int x)
        {
            int result = 0;

            while (x != 0)
            {
                int digit = x % 10;
                x /= 10;

                if (result > (int.MaxValue / 10) || (result == int.MaxValue / 10 && digit > 7))
                    return 0;
                if (result < (int.MinValue / 10) || (result == int.MinValue / 10 && digit < -8))
                    return 0;

                result = result * 10 + digit;
            }

            return result;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            
            var sol = new Solution();
            int result = sol.Reverse(1534236469);

            Console.WriteLine(result);
        }
    }
}
