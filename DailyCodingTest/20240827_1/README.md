# N개의 최소공배수 (programmers Lv 1)
 n개의 숫자를 담은 배열 arr이 입력되었을 때 이 수들의 최소공배수를 구해야 한다.
 입력 예 : [2,6,8,14]  
 출력 예 : 168
# 내가 푼 코드
 ```cs
  public int solution(int[] arr)
        {
            int[] temp = (int[])arr.Clone();
            while (true)
            {
                int min = Array.IndexOf(arr, arr.Min());
                arr[min] += temp[min];
                if (arr.Count(x => x == arr[0]) == arr.Length)
                {
                    break;
                }
            }
            return arr[0];
    }
 ```
# 풀이 방법
 1. 이게 되네
# 문제를 풀며 배운 것
 어려워 보이는 문제도 천천히 생각하니 쉽게 답을 구할 수 없었다.  
 멀리 뛰기를 2시간쯤 고민했는데 못 풀어서 이 문제로 도망쳤다.