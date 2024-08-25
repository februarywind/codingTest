# 최댓값과 최솟값 (programmers Lv 1)
 문자열 s가 주어졌을 때 최솟값과 최댓값을 구해야 한다.  
 입력 예 : "1 2 3 4"  
 출력 예 : "1 4"
# 내가 푼 코드
 ```cs
  public string solution(string s)
        {
            string answer = "";
            List<int> list = new List<int>();
            foreach (var item in s.Split(' ')) 
            {
                list.Add(int.Parse(item));
            }
            answer += list.Min().ToString();
            answer += ' ';
            answer += list.Max().ToString();
            return answer;
        }
 ```
# 풀이 방법
 1. s를 ' '로 잘라서 리스트에 삽입한다.
 1. 최댓값과 최솟값을 구한다.
# 문제를 풀며 배운 것
array.Select(x => x) 셀렉트 메서드를 활용해서 답을 구할 수 있었다.  
셀렉트 메서드는 배열의 각 요소에 계산을 할 수 있다.