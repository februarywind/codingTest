namespace programmersCodingTest
{
    internal class ProgrammersDay3
    {
        //프로그래머스 입문 Day2
        public int solution1(int num1, int num2) // 나머지 구하기
        {
            int answer = num1 % num2;
            return answer;
        }
        public int solution2(int[] array) // 중앙값 구하기
        {
            Array.Sort(array);
            int answer = array[array.Length / 2];
            return answer;
        }
        public int solution3(int[] array) // 최빈값 구하기 정렬하고 LastIndexOf로 해당 원소의 가장 마지막 위치 구해서 계산
        {
            Array.Sort(array);
            int count = 0;
            int num = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (count < Array.LastIndexOf(array, array[i]) - i + 1)
                {
                    count = Array.LastIndexOf(array, array[i]) - i + 1;
                    num = array[i];
                }
                else if (count == Array.LastIndexOf(array, array[i]) - i + 1)
                {
                    num = -1;
                }
                i = Array.LastIndexOf(array, array[i]);
            }
            return num;
        }
        public int[] solution4(int n) // 짝수는 싫어요
        {
            int[] answer = new int[1];
            for (int i = 1; i <= n; i += 2)
            {
                answer[answer.Length - 1] = i;
                Array.Resize(ref answer, answer.Length + 1);
            }
            Array.Resize(ref answer, answer.Length - 1);
            return answer;
        }
    }
}
