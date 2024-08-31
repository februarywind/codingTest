namespace _20240831_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution([7, 9, 1, 1, 4]));
        }
        public static int solution(int[] elements)
        {
            int answer = 0;
            int temp = 0;
            List<int> result = new List<int>();
            for (int i = 1; i <= elements.Length; i++)
            {
                for (int j = 0; j < elements.Length; j++)
                {
                    for (int k = 0; k < i; k++)
                    {
                        temp += elements[(j + k) % elements.Length];
                    }
                    result.Add(temp);
                    temp = 0;
                }
            }
            result = result.Distinct().ToList();
            return result.Count;
        }
    }
}
