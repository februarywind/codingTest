namespace _20240815_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(4, 1, [1,2,3,4]));
        }
        public static int solution(int n, int m, int[] section)
        {
            int answer = 0;
            Queue<int> queue = new Queue<int>(section);
            while (queue.Count > 0) 
            {
                if (queue.Count == 0) break;
                int tmep = queue.Peek() + m;
                for (int i = 0; i < m; i++)
                {
                    if (queue.Peek() < tmep)
                    {
                        queue.Dequeue();
                        if (queue.Count == 0) break;
                    }
                    else
                    {
                        break;
                    }
                }
                answer++;
            }
            return answer;
        }
    }
}
