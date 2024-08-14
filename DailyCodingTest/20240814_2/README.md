# 숫자 짝궁 (programmers Lv 1)
 두 개의 문자열이 주어졌을 때 두 문자열에서 공통으로 나타나는 문자들을 모아  
 가장 큰 정수를 만들어야 한다.  
 입력 예 : "100", "2345"    
 출력 예 : "-1"
# 내가 푼 코드
 ```cs
  public string solution(string X, string Y)
        {
            int[] xCount = new int[10];
            int[] yCount = new int[10];
            int[] xyCount = new int[10];

            foreach (var item in X)
            {
                xCount[item - '0']++;
            }

            foreach (var item in Y)
            {
                yCount[item - '0']++;
            }

            int temp = 0;
            for (int i = 0; i < 10; i++)
            {
                xyCount[i] = Math.Min(xCount[i], yCount[i]);
                temp += xyCount[i];
            }
            if (temp == 0)
            {
                return "-1";
            }
            if (temp == xyCount[0])
            {
                return "0";
            }
            StringBuilder answer = new StringBuilder();

            for (int i = 9; i >= 0; i--)
            {
                for (int j = 0; j < xyCount[i]; j++)
                {
                    answer.Append(i);
                }
            }
            return answer.ToString();
    }
 ```
# 풀이 방법
 1. 길이가 10인 배열 두 개를 만들어 각각 X와 Y를 순회하여 0~9 개수를 구한다.  
 2. 두 배열 중 작은 숫자들 모은 배열을 xyCount 만든다.
 3. xyCount 배열의 원소의 합이 0이라면 -1을 xyCount[0]와 같다면 0을 리턴한다.
 4. xyCount 배열의 인덱스를 원소 값만큼 반복하며 StringBuilder answer에 추가하고 리턴한다.
# 문제를 풀며 배운 것
 아니 300만 길이의 문자열 두 개를 처리하는데 당연히 시간이 foreach 문에서 오래 걸릴 줄 알고 answer는 대충 answer += i.ToString으로 처리했는데 
 고작 많아봐야 100번의 ToString이 그렇게 시간을 많이 잡아먹을 줄 몰랐다. 다시는 ToString을 쓰지 않겠습니다. 아이고 억울해라 내 시간