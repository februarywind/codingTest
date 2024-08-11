namespace _20240811_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            solution(3, [10, 100, 20, 150, 1, 100, 200]);
        }
        public static int[] solution(int k, int[] score)
        {
            int[] answer = new int[score.Length];
            List<int> list = new List<int>();

            for (int i = 0; i < score.Length; i++)
            {
                list.Add(score[i]);
                list.Sort();
                if (list.Count > k)
                {
                    list.Remove(list[0]);
                }
                answer[i] = list[0];
            }

            return answer;
        }

    }
}
