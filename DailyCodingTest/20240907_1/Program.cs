namespace _20240907_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution([3, 3, 3, 2], 3));
        }
        public static int solution(int[] priorities, int location)
        {
            int answer = 0;
            int l = priorities[location];
            priorities[location] = 0;
            Queue<int> q = new Queue<int>(priorities);
            while (q.Count > 1) 
            {
                int temp = q.Dequeue();
                if (temp == 0)
                {
                    if (l >= q.Max())
                        return ++answer;
                    else
                        q.Enqueue(0);
                }
                else
                {
                    if (temp >= q.Max() && temp >= l)
                        answer++;
                    else
                        q.Enqueue(temp);
                }
            }
            return priorities.Length;
        }
    }
}
