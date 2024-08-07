namespace _20240807_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(45));
        }
        public static int solution(int n)
        {
            int answer = 0;
            List<int> list = new List<int>();
            while (n > 0)
            {
                list.Add(n % 3);
                n /= 3;
            }
            for (int i = 0; i < list.Count; i++)
            {
                answer += list[i] * (int)Math.Pow(3, list.Count - 1 - i);
            }
            return answer;
        }
    }
}
