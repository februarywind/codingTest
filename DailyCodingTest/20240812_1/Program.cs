namespace _20240812_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            solution([1, 2, 3, 4, 5]);
        }
        public static int[] solution(int[] answers)
        {
            int[] answer = new int[3];
            int[] test1 = { 1, 2, 3, 4, 5 };
            int[] test2 = { 2, 1, 2, 3, 2, 4, 2, 5 };
            int[] test3 = { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

            for (int i = 0; i < answers.Length; i++)
            {
                if (answers[i] == test1[i % test1.Length])
                {
                    answer[0]++;
                }
                if (answers[i] == test2[i % test2.Length])
                {
                    answer[1]++;
                }
                if (answers[i] == test3[i % test3.Length])
                {
                    answer[2]++;
                }
            }
            int[] ints = answer.Where(x => x == answer.Max()).ToArray();
            if (ints.Length == 3)
            {
                return new int[] { 1, 2, 3 };

            }
            if (ints.Length == 2)
            {
                return new int[] { Array.IndexOf(answer, answer.Max()) + 1, Array.LastIndexOf(answer, answer.Max()) + 1 };
            }
            if (ints.Length == 1)
            {
                return new int[] { Array.IndexOf(answer, answer.Max()) + 1 };
            }
            return new int[] { };
        }
    }
}
