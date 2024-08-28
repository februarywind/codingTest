namespace _20240828_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            solution(5, ["hello", "observe", "effect", "take", "either", "recognize", "encourage", "ensure", "establish", "hang", "gather", "refer", "reference", "estimate", "executive"]);
        }
        public static int[] solution(int n, string[] words)
        {
            int[] answer = new int[2];
            Queue<string> queue = new Queue<string>(words);
            Stack<string> stack = new Stack<string>(queue.Count);
            bool t = false;
            while (queue.Count > 0)
            {
                if (!stack.Contains(queue.Peek()))
                {
                    stack.Push(queue.Dequeue());
                    if (queue.Count == 0)
                    {
                        break;
                    }
                }
                else
                {
                    t = true;
                }
                if (stack.Peek().Last() != queue.Peek()[0] || t)
                {
                    answer[0] = (stack.Count % n) + 1;
                    answer[1] = (stack.Count / n) + 1;
                    break;
                }
            }
            return answer;
        }
    }
}
