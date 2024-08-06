namespace _20240806_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 1, 1, 2, 3, 1, 2, 3, 1, };
            solution(a);
            //Console.WriteLine(new int[] { 1, 2, 3 } == new int[] { 1, 2, 3 }); 이거 왜 안됨?
        }

        public static int solution(int[] ingredient)
        {
            int answer = 0;
            Stack<int> stack = new Stack<int>(ingredient.Length);
            int[] ints = new int[4];
            int[] answers = { 1, 2, 3, 1 };
            foreach (var item in ingredient)
            {
                stack.Push(item);
                if (stack.Count > 3)
                {
                    ints[0] = stack.ElementAt(3);
                    ints[1] = stack.ElementAt(2);
                    ints[2] = stack.ElementAt(1);
                    ints[3] = stack.ElementAt(0);
                }

                if (Enumerable.SequenceEqual(ints, answers))
                {
                    answer++;
                    for (int i = 0; i < 4; i++)
                    {
                        stack.Pop();
                    }
                    ints[0] = -1;
                }
            }
            return answer;
        }
    }
}