namespace _20240822_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            solution(["muzi", "frodo", "apeach", "neo"], ["muzi frodo", "apeach frodo", "frodo neo", "muzi neo", "apeach muzi"], 2);
        }
        public static int[] solution(string[] id_list, string[] report, int k)
        {
            int[] answer = new int[id_list.Length];
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
            Dictionary<string, int> mail = new Dictionary<string, int>();
            for (int i = 0; i < id_list.Length; i++)
            {
                dic.Add(id_list[i], new List<string>());
                mail.Add(id_list[i], i);

            }
            foreach (var item in report)
            {
                string[] strings = item.Split(' ');
                if (!dic[strings[1]].Contains(strings[0]))
                {
                    dic[strings[1]].Add(strings[0]);
                }
            }
            foreach (var item in id_list)
            {
                if (dic[item].Count >= k)
                {
                    foreach (var item1 in dic[item])
                    {
                        answer[mail[item1]]++;
                    }
                }
            }
            foreach (var item in answer)
            {
                Console.WriteLine(item);   
            }
            return answer;
        }
    }
}
