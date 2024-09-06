namespace _20240906_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            solution([95, 90, 99, 99, 80, 99], [1, 1, 1, 1, 1, 1]);
        }
        public static int[] solution(int[] progresses, int[] speeds)
        {
            List<int> answer = new List<int>();
            for (int i = 0; i < progresses.Length; i++)
            {
                progresses[i] = (100 - progresses[i]) % speeds[i] == 0 ? (100 - progresses[i]) / speeds[i] : (100 - progresses[i]) / speeds[i] + 1;
            }
            Queue<int> q = new Queue<int>(progresses);
            q.Enqueue(int.MaxValue);
            int max = -1;
            int temp = 1;
            while (q.Count > 1)
            {
                max = Math.Max(max, q.Dequeue());
                if (max >= q.Peek())
                {
                    temp++;
                }
                else
                {
                    answer.Add(temp);
                    temp = 1;
                }
            }


            return answer.ToArray();
        }
    }
}
