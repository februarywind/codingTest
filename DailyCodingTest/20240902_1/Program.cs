namespace _20240902_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(["banana", "apple", "rice", "pork", "pot"], [3, 2, 2, 2, 1], ["chicken", "apple", "apple", "banana", "rice", "apple", "pork", "banana", "pork", "rice", "pot", "banana", "apple", "banana"]));
        }
        public static int solution(string[] want, int[] number, string[] discount)
        {
            int answer = 0;
            Dictionary<string, int> dic = new Dictionary<string, int>();
            Queue<string> _want = new Queue<string>(10);
            Queue<string> temp = new Queue<string>(10);
            for (int i = 0; i < want.Length; i++)
            {
                for (int j = 0; j < number[i]; j++)
                {
                    _want.Enqueue(want[i]);
                }
                dic.Add(want[i], number[i]);
            }
            foreach (var item in discount)
            {
                temp.Enqueue(item);
                if (temp.Count == 10)
                {
                    for (int i = 0; i < want.Length; i++)
                    {
                        if (temp.Count(x => x == want[i]) != dic[want[i]])
                        {
                            temp.Dequeue();
                            break;
                        }
                    }
                    if (temp.Count == 10)
                    {
                        temp.Dequeue();
                        answer++;
                    }
                }
            }
            return answer;
        }
    }
}
