namespace _20240903_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution([0]));
        }
        public static int solution(int[] citations)
        {
            int answer = 0;
            Array.Sort(citations);
            Stack<int> stack = new Stack<int>(citations);
            int count = stack.Count;
            for (int i = 0; i < count; i++)
            {
                int temp = stack.Pop();
                if (temp > answer && temp != 0)
                {
                    answer++;
                }
            }
            return answer;
        }
    }
}
