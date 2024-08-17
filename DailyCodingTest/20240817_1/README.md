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
 2. 여벌 체육복 학생을 Dequeue 해서 저장하고 잃어버린 학생에게 빌려 줄 수 있는지 검사한다.
 3. 그냥 내일 정리 해야지 에에엥.
# 문제를 풀며 배운 것
 토요일토요일