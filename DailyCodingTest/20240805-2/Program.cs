namespace _20240805_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] a = { "ayaye", "uuu", "yeye", "yemawoo", "ayaayaa" };
            solution(a);
        }

        public static int solution(string[] babbling)
        {
            int answer = 0;
            string[] ongal = { "aya", "ye", "woo", "ma" };
            for (int i = 0; i < babbling.Length; i++)
            {
                List<string> list = new List<string>();
                string temp = "";
                foreach (var item in babbling[i])
                {
                    temp += item;
                    if (Array.IndexOf(ongal, temp) != -1)
                    {
                        if (!(list.Count > 0 && list[list.Count - 1] == temp))
                        {
                            list.Add(temp);
                            temp = "";
                        }
                    }
                }
                temp = "";
                foreach (var item in list)
                {
                    temp += item;
                }
                if (babbling[i] == temp)
                {
                    answer++;
                }
            }
            return answer;
        }
    }
}
