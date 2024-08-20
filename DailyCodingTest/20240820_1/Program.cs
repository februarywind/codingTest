namespace _20240820_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            solution("2020.01.01", ["Z 103", "D 5"], ["2019.01.01 D", "2019.11.15 Z", "2019.08.02 D", "2019.07.01 D", "2018.12.28 Z"]);
        }
        public static int[] solution(string today, string[] terms, string[] privacies)
        {
            List<int> answer = new List<int>();
            Dictionary<Char, int> map = new Dictionary<Char, int>();
            DateTime day = DateTime.Parse(today);

            for (int i = 0; i < terms.Length; i++)
            {
                int a = int.Parse(terms[i].Substring(1));
                map.Add(terms[i][0], a);
            }
            for (int i = 0; i < privacies.Length; i++)
            {
                DateTime temp = DateTime.Parse(privacies[i].Substring(0, 10));
                int m = map[privacies[i][11]];
                temp = temp.AddMonths(m);
                if (temp <= day)
                {
                    answer.Add(i + 1);
                }
            }

            return answer.ToArray();
        }
    }
}
