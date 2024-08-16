namespace _20240816_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution("abracadabra"));
        }
        public static int solution(string s)
        {
            int answer = 0;
            int[] check = new int[2];
            Queue<char> queue = new Queue<char>(s);
            char first = queue.Peek();
            while (queue.Count > 0) 
            {
                if (queue.Count == 1)
                {
                    answer++;
                    break;
                }
                if (first == queue.Dequeue())
                {
                    check[0]++;
                }
                else
                {
                    check[1]++;
                }
                if (check[0] == check[1])
                {
                    queue.TryPeek(out first);
                    answer++;
                }
            }
            return answer;
        }
    }
}
