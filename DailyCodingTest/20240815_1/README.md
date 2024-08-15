# 소수 찾기 (programmers Lv 1)
 정수 n이 주어졌을 때 1부터 n까지의 소수의 개수를 구해야 한다.  
 입력 예 : 10  
 출력 예 : 4
# 내가 푼 코드
 ```cs
  public int solution(int n)
        {
            if (n == 2)
                return 1;
            int answer = 1;
            List<int> list = new List<int>(n / 2);
            for (int i = 3; i <= n; i += 2)
            {
                list.Add(i);
            }
            while (list[0] < Math.Sqrt(n))
            {
                int temp = list[0];
                list = list.Where(x => x % temp != 0).ToList();
                answer++;
            }
            return answer + list.Count;
    }
 ```
# 풀이 방법
 1. 입력이 2라면 1을 리턴한다.
 2. 3부터 시작해서 n까지의 홀수만 리스트에 추가하고 소수 2가 리스트에 없기에 answer는 1로 시작한다.
 3. where메서드로 리스트의 첫 번째 값과 약수인 수를 제거한다. 이것을 n의 제곱근 반복한다.
 4. 제거된 개수만큼 answer에 더하고 리스트의 남은 개수를 합하여 리턴한다.
# 문제를 풀며 배운 것
 에라토스테네스의 체로 소수의 개수를 구할 때 입력 값 제곱근까지의 배수만 제거하면 된다고 한다.  
 왜인지 알 것 같으면서도 모르겠으면서도 알 것 같기도 하고 아닌 것 같기도 하고