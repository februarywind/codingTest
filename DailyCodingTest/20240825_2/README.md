# 카펫 (programmers Lv 1)
 테두리의 색갈이 brown, 이외의 색갈이 yellow인 카펫이 있다.  
 카펫에서 갈색 격자의 수 brown, 노란색 격자의 수 yellow가 매개변수로 주어질 때 카펫의 가로, 세로 크기를 구해야 한다.  
 입력 예 : 10, 2  
 출력 예 : [4, 3]
# 내가 푼 코드
 ```cs
  public int[] solution(int brown, int yellow)
        {
            int[] answer = { 1, yellow };
            for (int i = 1; i <= yellow; i++)
            {
                if (yellow % i == 0)
                {
                    answer[0] = 1 * i;
                    answer[1] = yellow / i;
                }
                if ((answer[0] * 2) + (answer[1] * 2) + 4 == brown)
                {
                    answer[0] += 2;
                    answer[1] += 2;
                    break;
                }
            }
            Array.Sort(answer);
            Array.Reverse(answer);
            return answer;
    }
 ```
# 풀이 방법
 1. answer에 1과 yellow를 저장한다.
 1. yellow 만큼 반복하면서 yellow가 i로 나누어떨어진다면 i * yellow / i 크기의 직사각형이 만들어질 수 있다.
 1. 만들어질 수 있는 사각형의 테두리 크기가 brown과 같다면 answer에 2(꼭짓점)를 더해서 답을 구한다.
# 문제를 풀며 배운 것
 어차피 모든 i를 체크할 거면 첫 번째 if 문은 굳이 필요 없었다. else에 countine를 넣었어야 했나?