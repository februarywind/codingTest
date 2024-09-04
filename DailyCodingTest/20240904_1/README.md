# n^2 배열 자르기 (programmers Lv 2)
 정수 n, left, right가 매개변수로 주어집니다. 주어진 과정대로 만들어진 1차원 배열을 구해야 한다.
 입력 예 : 3, 2, 5  
 출력 예 : [3,2,2,3]
# 내가 푼 코드
 ```cs
  public int[] solution(int n, long left, long right)
        {
            List<int> answer = new List<int>();
            int l = (int)(left / n) + 1;
            int r = (int)(right / n) + 2;
            for (int i = l; i < r; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    answer.Add(i);
                }
                for (int j = 1; j <= n - i; j++)
                {
                    answer.Add(i + j);
                }
            }
            return answer.GetRange((int)(left % n), (int)(right - left) + 1).ToArray();
    }
 ```
# 풀이 방법
 1. left와 right가 생성될 배열의 몇 번째 줄인지 구하고 그 차만큼 반복한다.
 1. 우선 l + i를 i 만큼 리스트에 추가한다.
 1. 그리고 n - i 번 반복하여 해당 줄의 나머지 값을 채운다.
 1. 구한 배열에서 left가 시작되는 위치를 구하여 GetRange를 통해 답을 구한다.
# 문제를 풀며 배운 것
 그냥 머리가 좋아야 풀 수 있는 문제 같다. 겁나게 헤맸다.