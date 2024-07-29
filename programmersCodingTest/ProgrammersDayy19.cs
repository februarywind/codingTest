namespace programmersCodingTest
{
    internal class ProgrammersDayy19
    {
        //프로그래머스 입문 Day19
        public int solution1(int[] array) // 7의 개수
        {
            string s = "";
            for (int i = 0; i < array.Length; i++)
            {
                s += array[i];
            }
            return s.Count(x => x == '7');
        }
        public string[] solution2(string my_str, int n) // 잘라서 배열로 저장하기
        {
            string[] answer = new string[(my_str.Length % n == 0) ? my_str.Length / n : my_str.Length / n + 1];
            for (int i = 0; i < answer.Length; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    answer[i] += my_str[j + i * n];
                    if (j + i * n == my_str.Length - 1)
                    {
                        break;
                    }
                }
            }
            return answer;
        }
        public int solution3(int[] array, int n) // 중복된 숫자 개수
        {
            return array.Count(x => x == n);
        }
        public int solution4(int[] array, int height) // 머쓱이보다 키 큰 사람
        {
            int answer = 0;
            foreach (var item in array)
            {
                if (item > height)
                {
                    answer++;
                }
            }
            return answer;
        }
    }
}
