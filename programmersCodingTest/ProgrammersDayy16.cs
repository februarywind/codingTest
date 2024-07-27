namespace programmersCodingTest
{
    internal class ProgrammersDayy16
    {
        //프로그래머스 입문 Day16
        public int solution1(string message) // 편지
        {
            return message.Length * 2;
        }
        public int[] solution2(int[] array) // 가장 큰 수 찾기
        {
            int[] answer = { array.Max(), Array.IndexOf(array, array.Max()) };
            return answer;
        }
        public int solution3(string my_string) // 문자열 계산하기
        {
            List<string> list = my_string.Split(' ').ToList();
            int space = list.Count(x => x == " ");
            for (int i = 0; i <= space; i++)
            {
                list.Remove(" ");
            }
            int answer = int.Parse(list[0]);
            for (int i = 2; i < list.Count(); i++)
            {
                if (list[i - 1] == "+")
                {
                    answer += int.Parse(list[i]);
                }
                else if (list[i - 1] == "-")
                {
                    answer -= int.Parse(list[i]);
                }
            }
            return answer;
        }
        public int solution4(string[] s1, string[] s2) // 배열의 유사도
        {
            int answer = 0;
            foreach (var item in s1)
            {
                if (Array.IndexOf(s2, item) != -1)
                {
                    answer++;
                }
            }
            return answer;
        }
    }
}
