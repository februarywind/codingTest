namespace _20240824_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution("1 2 3 4"));
        }
        public static string solution(string s)
        {
            string answer = "";
            List<int> list = new List<int>();
            foreach (var item in s.Split(' ')) 
            {
                list.Add(int.Parse(item));
            }
            answer += list.Min().ToString();
            answer += ' ';
            answer += list.Max().ToString();
            return answer;
        }
    }
}
