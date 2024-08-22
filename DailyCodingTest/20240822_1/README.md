# 공원 산책 (programmers Lv 1)
 공원을 나타내는 문자열 배열 park, 로봇 강아지가 수행할 명령이 담긴 문자열 배열 routes가 매개변수로 주어질 때  
 로봇 강아지가 모든 명령을 수행 후 놓인 위치를 구해야 한다.  
 입력 예 : ["SOO","OOO","OOO"], ["E 2","S 2","W 1"]  
 출력 예 : [2, 1]
# 내가 푼 코드
 ```cs
  public int[] solution(string[] park, string[] routes) {
        int[] answer = { park.Length - 1, park[0].Length - 1 };
        int[] s = { -1, -1 };
        for (int i = 0; i < park.Length; i++)
        {
            for (int j = 0; j < park[i].Length; j++)
            {
                if (park[i][j] == 'S')
                {
                    s[0] = i;
                    s[1] = j;
                    break;
                }
            }
            if (s[0] != -1)
                break;
        }
        foreach (var item in routes)
        {
            int[] temp = (int[])s.Clone();
            int p = (item[0] == 'E' || item[0] == 'S') ? 1 : -1;
            int f = int.Parse(item.Substring(1));
            for (int i = 0; i < f; i++)
            {
                if (item[0] == 'E' || item[0] == 'W')
                {
                    temp[1] += 1 * p;
                    if (temp[1] > answer[1] || temp[1] < 0)
                    {
                        temp = (int[])s.Clone();
                        break;
                    }
                }
                else
                {
                    temp[0] += 1 * p;
                    if (temp[0] > answer[0] || temp[0] < 0)
                    {
                        temp = (int[])s.Clone();
                        break;
                    }
                }
                if (park[temp[0]][temp[1]] == 'X')
                {
                    temp = (int[])s.Clone();
                    break;
                }
            }
            s = (int[])temp.Clone();
        }
        return s;
    }
 ```
# 풀이 방법
 1. answer 배열에 park 배열의 길이를 저장한다.
 1. park 배열을 순회하면서 출발점 s를 구한다.
 1. routes를 순회할 때마다 temp 배열에 현재 위치를 저장하고 방향이 E, S라면 증가하는 쪽이니 p 값을 +1 이외에는 -1로 지정한다
 1. routes 값만큼 반복한다. 만약 temp의 위치가 park를 초과하거나 X라면 s 값을 변화시키지 않고 break 한다.
 1. 이상 없이 routes 값만큼 반복했다면 그 위치를 s에 대입하여 값을 구한다.
# 문제를 풀며 배운 것
 array.Clone()을 사용할 때는 앞에 형 변환 메서드를 사용해야 한다.