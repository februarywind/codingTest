namespace _20240904_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            solution(4, 7, 14);
        }
        public static int[] solution(int n, long left, long right)
        {
            List<int> answer = new List<int>();
            int l = (int)(left / n) + 1;
            int r = (int)(right / n) + 2;
            for (int i = l; i < r; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    answer.Add(i);
                }
                for (int j = 1; j <= n - i; j++)
                {
                    answer.Add(i + j);
                }
            }
            return answer.GetRange((int)(left % n), (int)(right - left) + 1).ToArray();
        }
    }
}
