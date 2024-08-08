# 2016년 (programmers Lv 1)
 2016년의 월과 일이 정수로 주어진다.
 2016년 a월 b일의 요일을 출력해야한다.
 입력 예 : 5, 24  
 출력 예 : "TUE"  
# 내가 푼 코드
 ```cs
  public string solution(int a, int b) {
        DateTime day = new DateTime(2016, a, b);
        return day.DayOfWeek.ToString().ToUpper().Substring(0, 3);
    }
 ```
# 풀이 방법
 1. DateTime의 DayOfWeek으로 요일을 얻을 수 있다.
 2. 소문자로 값이 나오기 때문에 ToUpper()를 통해서 대문자로 만들고 Substring으로 앞에 3글자만 출력시켰다.
# 문제를 풀며 배운 것
 DayOfWeek으로 요일을 출력할 수 있다는 것을 배웠다.  

 