namespace _20240816_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(["AA"],["B"]));
        }
        public static int[] solution(string[] keymap, string[] targets)
        {
            int[] answer = new int[targets.Length];
            for (int i = 0; i < targets.Length; i++)
            {
                foreach (var item in targets[i])
                {
                    int temp = 100;
                    for (int j = 0; j < keymap.Length; j++)
                    {
                        int index = Array.IndexOf(keymap[j].ToCharArray(), item);
                        if (index < temp && index != -1)
                        {
                            temp = index;
                        }
                    }
                    if (temp == 100)
                    {
                        answer[i] = -1;
                        break;
                    }
                    answer[i] += (temp + 1);
                }
            }
            return answer;
        }
    }
}
