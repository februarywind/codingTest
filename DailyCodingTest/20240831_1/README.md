# 연속 부분 수열 합의 개수 (programmers Lv 2)
 원형 수열의 모든 원소 elements가 순서대로 주어질 때,  
 원형 수열의 연속 부분 수열 합으로 만들 수 있는 수의 개수를 구해야 한다.
 입력 예 : [7,9,1,1,4]  
 출력 예 : 18
# 내가 푼 코드
 ```cs
  public int solution(int[] elements) {
        int temp = 0;
        List<int> result = new List<int>();
        for (int i = 1; i <= elements.Length; i++)
        {
            for (int j = 0; j < elements.Length; j++)
            {
                for (int k = 0; k < i; k++)
                {
                    temp += elements[(j + k) % elements.Length];
                }
                result.Add(temp);
                temp = 0;
            }
        }
        result = result.Distinct().ToList();
        return result.Count;
    }
 ```
# 풀이 방법
 1. 첫 번째 반복문 i로 몇개의 원소를 더할지 구한다.
 1. 두 번째 반복문으로 주어진 배열을 순회 하며
 1. 세 번째 반복문으로 i개를 더해 리스트에 추가하고 중복을 제거하여 답을 구한다.
# 문제를 풀며 배운 것
 AddRange로 풀 수 있었을지도