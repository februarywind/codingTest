namespace _20240830_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(4,[1, 3, 2, 5, 4, 5, 2, 3]));
        }
        public static int solution(int k, int[] tangerine)
        {
            int answer = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();
            foreach (var item in tangerine)
            {
                if (map.ContainsKey(item))
                {
                    map[item]++;
                }
                else
                {
                    map.Add(item, 1);
                }
            }
            List<int> list = new List<int>(map.Values);
            list.Sort();
            list.Reverse();
            foreach (var item in list)
            {
                k -= item;
                answer++;
                if (k <= 0)
                {
                    break;
                }
            }
            return answer;
        }
    }
}
