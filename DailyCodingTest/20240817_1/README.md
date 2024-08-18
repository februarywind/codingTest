# 체육복 (programmers Lv 1)
 총 학생의 수 n명 중 체육복을 잃어버린 학생과 여벌의 체육복을 하나 가지고 온 학생이 주어졌을때  
 체육복을 가장 많이 입을 수 있는 경우의 학생의 수를 구해야 한다.
 입력 예 : 5, [2, 4], [1, 3, 5]  
 출력 예 : 5
# 내가 푼 코드
 ```cs
  public class Solution {
    public int solution(int n, int[] lost, int[] reserve)
        {
            Array.Sort(lost);
            Array.Sort(reserve);
        
            List<int> _lost = new List<int>(lost.Where(x => Array.IndexOf(reserve, x) == -1));
            Queue<int> _reserve = new Queue<int>(reserve.Where(x => Array.IndexOf(lost, x) == -1));
            int answer = n - _lost.Count;

            while (_reserve.Count > 0)
            {
                int temp = _reserve.Dequeue();
                for (int i = 0; i < _lost.Count; i++)
                {

                    if (temp == _lost[i] - 1 || temp == _lost[i] + 1)
                    {
                        _lost.RemoveAt(i);
                        answer++;
                    }
                    if (_lost.Count == 0)
                        break;
                }

            }

            return answer;
    }
 ```
# 풀이 방법
 1. 입력 값을 정렬하고 두 배열의 중복 값을 제거한다. 여벌의 체육복을 잃어버린 학생은 없는 것과 같기 때문.
 1. 일차적으로 체육복을 가진 학생의 수는 (총 학생의 수 - 잃어버린 학생의 수)이므로 answer = n - _lost.Count;
 1. 여벌 체육복 학생들 _reserve를 Dequeue 하여 빌려줄 수 있는 학생이 있을 때만 _lost도 Dequeue 한다. 이것을 _reserve가 0이 될 때까지 반복한다.
 1. 빌려줄 수 있을 때마다 answer에 1을 더해서 답을 구한다.
# 문제를 풀며 배운 것
 주말에도 한 문제 정도는 풀 수 있다.