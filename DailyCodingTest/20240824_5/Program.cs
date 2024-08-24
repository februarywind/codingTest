namespace _20240824_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            solution("101010101101");
        }
        public static int[] solution(string s)
        {
            int[] answer = new int[2];
            List<char> list = new List<char>(s);
            int l = 0;
            while (list.Count > 1)
            {
                l = list.Count;
                list = list.Where(x => x == '1').ToList();
                answer[1] += l  - list.Count;
                answer[0]++;

                list = new List<char>(Convert.ToString(list.Count, 2));

            }
            return answer;
        }
    }
}
