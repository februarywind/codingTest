# 최솟값 만들기 (programmers Lv 1)
 배열 A, B가 주어질 때 두 배열의 원소를 각각 곱했을 때 가장 적은 수를 구해야 한다.   
 입력 예 : [1, 4, 2], [5, 4, 4]  
 출력 예 : 29
# 내가 푼 코드
 ```cs
  public int solution(int[] A, int[] B)
        {
            int answer = 0;
            Array.Sort(A);
            Array.Sort(B);
            B = B.Reverse().ToArray();
            for (int i = 0; i < A.Length; i++)
            {
                answer += A[i] * B[i];
            }
            return answer;
    }
 ```
# 풀이 방법
 1. A를 오름차순 B를 내림차순으로 정렬한다.
 1. 두 원소를 각각 곱하며 answer에 더해 답을 구한다.
# 문제를 풀며 배운 것
 Array.Reverse(array)로 더 쉽게 역순 정렬을 할 수 있다.