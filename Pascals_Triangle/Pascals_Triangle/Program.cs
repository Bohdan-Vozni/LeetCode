namespace Pascals_Triangle
{
    public class Solution
    { 
        public IList<IList<int>> Generate (int numRows)
        {
            IList<IList<int>> list = new List<IList<int>>();

            for (int i = 0; i < numRows; i++)
            {
                if (i == 0)
                {
                    list.Add(new List<int> { 1 });
                    continue;
                }

                List<int> listCurrent = new List<int>();
                IList<int> listPast = list[i -1];

                listCurrent.Add(1);
                
                for (int j = 0; j < listPast.Count -1; j++)
                {
                    listCurrent.Add(listPast[j] + listPast[j+1]);
                }

                listCurrent.Add(1);

                list.Add(listCurrent);
            }
            return list;   
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();
            var result = sol.Generate(15);

            foreach (var item in result)
            {
                foreach (var item2 in item)
                {
                    Console.Write(item2.ToString() + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
