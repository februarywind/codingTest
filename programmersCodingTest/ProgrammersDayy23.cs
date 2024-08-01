namespace programmersCodingTest
{
    internal class ProgrammersDayy23
    {
        //프로그래머스 입문 Day23
        public int[] solution1(int[] numlist, int n) // 특이한 정렬
        {
            List<int> list = new List<int>();
            for (int i = 0; i < numlist.Length; i++)
            {
                int abs = Math.Abs(numlist[i] - n);
                if (numlist[i] - n < 0)
                {
                    list.Add(abs + n);
                }
                numlist[i] = abs;
            }
            Array.Sort(numlist);
            for (int i = 0; i < numlist.Length; i++)
            {
                numlist[i] += n;
            }
            foreach (var item in list)
            {
                int check = Array.LastIndexOf(numlist, item);
                if (check != -1)
                {
                    numlist[check] -= n * 2;
                    numlist[check] *= -1;
                }
            }

            return numlist;
        }
        public int[] solution2(int[,] score) // 등수 매기기
        {
            int[] answer = new int[score.GetLength(0)];
            for (int i = 0; i < score.GetLength(0); i++)
            {
                answer[i] += score[i, 0] + score[i, 1];
            }
            int[] temp = new int[score.GetLength(0)];
            Array.Copy(answer, 0, temp, 0, answer.Length);
            Array.Sort(temp);
            Array.Reverse(temp);
            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = Array.IndexOf(temp, answer[i]) + 1;
            }
            return answer;
        }
        public int solution3(string[] babbling) // 옹알이 (1)
        {
            int answer = 0;
            string[] ongal = { "aya", "ye", "woo", "ma" };
            for (int i = 0; i < babbling.Length; i++)
            {
                int temp = 0;
                foreach (var item in ongal)
                {
                    if (babbling[i].IndexOf(item) != -1)
                    {
                        temp += item.Length;
                    }
                }
                if (temp == babbling[i].Length)
                {
                    answer++;
                }
                temp = 0;
            }
            return answer;
        }

        public string solution4(string[] id_pw, string[,] db) // 로그인 성공?
        {
            string answer = "fail";
            foreach (var item in db)
            {
                if (answer == "wrong pw" && id_pw[1] == item)
                {
                    return "login";
                }
                if (answer == "wrong pw")
                    return answer;
                if (id_pw[0] == item)
                {
                    answer = "wrong pw";
                }
            }
            return answer;
        }
    }
}
