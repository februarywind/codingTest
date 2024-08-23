namespace _20240823_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            solution(["joy", "brad", "alessandro", "conan", "david"],["alessandro brad", "alessandro joy", "alessandro conan", "david alessandro", "alessandro david"]);
        }
        public static int solution(string[] friends, string[] gifts)
        {
            int answer = 0;
            Dictionary<string, List<string>> present = new Dictionary<string, List<string>>();
            Dictionary<string, int> presentIndex = new Dictionary<string, int>();

            foreach (var item in friends)
            {
                present.Add(item, new List<string>());
                presentIndex.Add(item, 0);
            }

            foreach (var item in gifts)
            {
                present[item.Split(' ')[0]].Add(item.Split(' ')[1]);
                presentIndex[item.Split(' ')[0]]++;
                presentIndex[item.Split(' ')[1]]--;
            }

            foreach (var item in friends)
            {
                int tmep = 0;
                foreach (var item1 in friends)
                {
                    if (present[item].Count(x => x == item1) == present[item1].Count(x => x == item))
                    {
                        tmep += presentIndex[item] > presentIndex[item1] ? 1 : 0;
                        continue;
                    }
                    if (present[item].Count(x => x == item1) > present[item1].Count(x => x == item))
                    {
                        tmep++;
                    }
                }
                answer = Math.Max(answer, tmep);
            }

            return answer;
        }
    }
}
