/* 
200716 https://www.acmicpc.net/problem/10951

C# 너무 오랜만이라 잘 기억이 안난다. 되살리자.
String.IsNullOrEmpty()에 대해 알게됨. 
조건문안에서 입력과 조건 검사까지 하려니 생각보다는 헷갈렸지만, 해결 완료.
*/

using System;

public class main {
	public static void Main() {
        string s;
        string[] ss;

        int a, b;
		
        while(String.IsNullOrEmpty(s = Console.ReadLine()) != true) {
            ss = s.Split();

            a = int.Parse(ss[0]);
            b = int.Parse(ss[1]);

            Console.WriteLine(a+b);
        }
	}
}

/* 
200716 https://www.acmicpc.net/problem/10952

a, b가 둘 다 0이면 break를 or 연산으로 해결
*/
using System;

public class main {
	public static void Main() {
        string s;
        string[] ss;

        int a, b;
		
        while(String.IsNullOrEmpty(s = Console.ReadLine()) != true) {
            ss = s.Split();

            a = int.Parse(ss[0]);
            b = int.Parse(ss[1]);
			
			if(0 == (a|b)) 
				break;
			
            Console.WriteLine(a+b);
        }
	}
}

/* 
200716 https://www.acmicpc.net/problem/10953

string.Split()에서 Split 안에 인자로 원하는 문자를 넣으면 그걸로 split 가능함.
*/
using System;

public class main {
	public static void Main() {
        string s;
        string[] ss;

        int a, b;
		
		int count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++) {
			s = Console.ReadLine();
            ss = s.Split(',');

            a = int.Parse(ss[0]);
            b = int.Parse(ss[1]);
			
            Console.WriteLine(a+b);
        }
	}
}

/* 
200716 https://www.acmicpc.net/problem/11021

for문 사용.
*/
using System;

public class main {
	public static void Main() {
        string s;
        string[] ss;

        int a, b;
		
		int j = int.Parse(Console.ReadLine());
		
        for (int i = 1; i <= j; i++) {
			s = Console.ReadLine();
            ss = s.Split();

            a = int.Parse(ss[0]);
            b = int.Parse(ss[1]);
			
            Console.WriteLine("Case #"+ i + ": " + (a+b));
        }
	}
}

/* 
200716 https://www.acmicpc.net/problem/11022

for문 사용.
위에랑 똑같은 문제임
*/
using System;

public class main {
	public static void Main() {
        string s;
        string[] ss;

        int a, b;
		
		int j = int.Parse(Console.ReadLine());
		
        for (int i = 1; i <= j; i++) {
			s = Console.ReadLine();
            ss = s.Split();

            a = int.Parse(ss[0]);
            b = int.Parse(ss[1]);
			
            Console.WriteLine("Case #"+ i + ": " + a + " + " + b + " = " + (a+b));
        }
	}
}

/* 
200716 https://www.acmicpc.net/problem/11718

단순히 받은 문자열 출력하는 프로그램
*/
using System;

public class main {
	public static void Main() {
		
		string s;
		
		while(String.IsNullOrEmpty(s = Console.ReadLine()) != true) {
			
			Console.WriteLine(s);
		}
	}
}
