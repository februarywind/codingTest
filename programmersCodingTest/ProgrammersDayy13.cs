namespace programmersCodingTest
{
    internal class ProgrammersDayy13
    {
        //프로그래머스 입문 Day13
        public int solution1(string s) // 컨트롤 제트
        {
            string[] words = s.Split(' ');
            int answer = 0;
            int temp = 0;
            int temp2 = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (int.TryParse(words[i], out temp))
                {
                    temp2 = temp;
                    answer += temp;
                }
                else
                {
                    answer += temp2 * -1;
                }
            }
            return answer;
        }
        public int[] solution2(string[] strlist) // 배열 원소의 길이
        {
            int[] answer = new int[strlist.Length];
            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = strlist[i].Length;
            }
            return answer;
        }
        public string solution3(string my_string) // 중복된 문자 제거
        {
            string answer = "";
            char[] chars = answer.ToCharArray();
            foreach (var item in my_string)
            {
                if (Array.IndexOf(chars, item) == -1)
                {
                    answer += item;
                    chars = answer.ToCharArray();
                }
            }
            return answer;
        }
        public int solution4(int[] sides) //삼각형의 완성조건 (1)
        {
            int max = sides.Max(x => x);
            int sum = sides.Sum(x => x) - max;
            int answer = (max < sum) ? 1 : 2;
            return answer;
        }
    }
}
