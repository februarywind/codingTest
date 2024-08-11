namespace _20240811_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            solution(["i", "water", "drink"], ["want", "to"],["i", "want", "to", "drink", "water"]);
        }
        public static string solution(string[] cards1, string[] cards2, string[] goal)
        {
            Queue<string> queue1 = new Queue<string>(cards1);
            Queue<string> queue2 = new Queue<string>(cards2);
            Queue<string> queue3 = new Queue<string>(goal);
            queue1.Enqueue("END");
            queue2.Enqueue("END");
            for (int i = 0; i < goal.Length; i++)
            {
                if (queue1.Peek() == queue3.Peek())
                {
                    queue1.Dequeue();
                    queue3.Dequeue();
                }
                else if (queue2.Peek() == queue3.Peek())
                {
                    queue2.Dequeue();
                    queue3.Dequeue();
                }
                else
                {
                    return "No";
                }
            }

            return "Yes";
        }
    }
}
