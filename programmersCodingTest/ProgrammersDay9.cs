namespace programmersCodingTest
{
    internal class ProgrammersDay9
    {
        //프로그래머스 입문 Day9
        public int solution1(int hp) // 개미 군단 
        {
            int answer = 0;
            answer += hp / 5;
            hp = hp % 5;
            answer += hp / 3;
            hp = hp % 3;
            answer += hp;
            return answer;
        }
        public string solution2(string letter) // 모스 부호
        {
            string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            string answer = "";
            string answer1 = "";
            for (int i = 0; i < letter.Length; i++)
            {
                if (letter[i] != ' ')
                {
                    answer += letter[i];
                }
                else
                {
                    answer1 += (char)('a' + Array.IndexOf(morse, answer));
                    answer = "";
                }
            }
            answer1 += (char)('a' + Array.IndexOf(morse, answer));
            return answer1;
        }
        public string solution3(string rsp) // 가위 바위 보
        {
            string answer = "";
            foreach (var item in rsp)
            {
                answer += (item == '2') ? "0" : (item == '0') ? "5" : "2";
            }
            return answer;
        }
        public int solution4(int balls, int share) // 구슬을 나누는 경우의 수 이건 진짜 어떻게 푼건지도 모르겠다.
        {
            int[] a = new int[0];

            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Array.Resize(ref a, a.Length + 1);
                    int L = Array.IndexOf(a, 0);
                    if (j == 0)
                    {
                        a[L] = i + 1;
                        continue;
                    }
                    if (j == i)
                    {
                        a[L] = 1;
                        continue;
                    }
                    a[L] = a[L - i] + a[L - i - 1];
                }
            }
            int sum = 0;
            for (int i = 1; i < balls; i++)
            {
                sum += i;
            }
            return (a[sum + share - 1]);
        }
    }
}
