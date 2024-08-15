namespace _20240815_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(2));
        }
        public static int solution(int n)
        {
            if (n == 2)
            {
                return 1;
            }
            int answer = 1;
            List<int> list = new List<int>(n / 2);
            for (int i = 3; i <= n; i += 2)
            {
                list.Add(i);
            }
            while (list[0] < Math.Sqrt(n))
            {
                int temp = list[0];
                list = list.Where(x => x % temp != 0).ToList();
                answer++;
            }
            return answer + list.Count;
        }
    }
}
