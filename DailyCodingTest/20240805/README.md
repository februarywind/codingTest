# 푸드 파이트 대회 (programmers Lv 1)
 푸드 파이트 대회를 개최하기 위해 테이블을 세팅 해야 한다.  
 입력 배열의 값은 해당 인덱스 만큼의 칼로리를 가지는 음식이며 [0]은 물을 뜻하며 값은 항상 1이다.  
 두명의 선수가 양 끝에서 적은 칼로리의 음식 부터 먹어야 하고 두 선수는 같은 양의 음식을 같은 순서대로 먹어야 한다.  
 음식의 중앙에는 물을 배치해야 한다.  
 입력 예: [1, 3, 4, 6]	
 출력 예 : "1223330333221"  
# 내가 푼 코드
 ```cs
  public string solution(int[] food) {
        string answer = "";
        for(int i = 1; i < food.Length; i++)
        {
            for(int j = 0; j < food[i] / 2; j++)
            {
                answer += i;
            }
        }
        char[] chars = answer.ToCharArray();
        Array.Reverse(chars);
        answer += '0' + new string(chars);
        return answer;
    }
 ```
  나는 해당 문제를 우선 왼쪽의 참가자가 먹을 테이블을 세팅하고 이를 뒤집어서 한 번 더 추가하는 방식으로 해결했다.  
  입력받은 배열의 첫 번째부터 음식이 있기에 반복문을 1부터 food.Length까지 진행하며 각각 배열 값의 절반만큼 다시 반복하여 빈 문자열에 해당 값들을 넣는다.  
  그리고 완성된 문자열을 char[]으로 변환하여 chars에 저장하고 Array.Reverse(chars);로 역순 정렬하였다. 그리고 '0'과 뒤집힌 배열을 추가하여 문제를 해결했다.
