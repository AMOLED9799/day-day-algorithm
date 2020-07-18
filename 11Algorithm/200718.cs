/*
https://www.acmicpc.net/problem/1330
*/

using System;

class MainClass {
  public static void Main (string[] args) {
    string s = Console.ReadLine();
    string[] ss = s.Split();
    
    int a = int.Parse(ss[0]);
    int b = int.Parse(ss[1]);

    if (a>b) {
      Console.WriteLine(">");
    } 
    else if (a<b) {
      Console.WriteLine("<");
    } 
    else {
      Console.WriteLine("==");
    }
  }
}

/*
https://www.acmicpc.net/problem/9498
*/
using System;

class MainClass {
  public static void Main (string[] args) {
    string s = Console.ReadLine();
    
    int score = int.Parse(s);

    if (score >= 90) {
      Console.WriteLine("A");
    } else if (score >= 80) {
      Console.WriteLine("B");
    } else if (score >= 70) {
      Console.WriteLine("C");
    } else if (score >= 60) {
      Console.WriteLine("D");
    } else {
      Console.WriteLine("F");
    }
  }
}

/*
https://www.acmicpc.net/problem/2753

윤년 계산
*/
using System;

class MainClass {
  public static void Main (string[] args) {
    string s = Console.ReadLine();
    
    int year = int.Parse(s);

    if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)) {
        Console.WriteLine("1");
    } else {
        Console.WriteLine("0");
    }
  }
}

/*
https://www.acmicpc.net/problem/14681
*/
using System;

class MainClass {
    public static void Main (string[] args) {
        string x = Console.ReadLine();
        string y = Console.ReadLine();

        int xx = int.Parse(x);
        int yy = int.Parse(y);

        if (xx > 0 && yy > 0) {
            Console.WriteLine("1");
        } else if (xx < 0 && yy > 0) {
            Console.WriteLine("2");
        } else if (xx < 0 && yy < 0) {
            Console.WriteLine("3");
        } else {
            Console.WriteLine("4");
        }
    }
}

/*
https://www.acmicpc.net/problem/2884
*/
using System;

class MainClass {
    public static void Main (string[] args) {
        string inputTime = Console.ReadLine();

        int hour = int.Parse((inputTime.Split())[0]);
        int minute = int.Parse((inputTime.Split())[1]);

        if(minute < 45) {
            minute += 15;
            if(hour <1) {
                hour = 23;
            } else {
                hour -=1;
            }
        } else {
            minute -= 45;
        }

        Console.WriteLine(hour + " " + minute);
    }
}

/*
https://www.acmicpc.net/problem/8393
*/
using System;

class MainClass {
    public static void Main (string[] args) {
        int sum = 0;

        for (int j = 1, i = int.Parse(Console.ReadLine()); j<=i; j++) {
            sum += j;
        }

        Console.WriteLine(sum);
    }
}

/*
https://www.acmicpc.net/problem/15552
밥먹고와서 풀 것

참고 사이트
https://jaeho0613.tistory.com/39
*/

using System;
using System.Text;
using System.IO;

class MainClass {
    public static void Main (string[] args) {
        StringBuilder sb = new StringBuilder();
        string[] data;

        int maxCase = int.Parse(Console.ReadLine());

        for (int i = 0; i < maxCase; i++) {
            data=Console.ReadLine().Split();

            sb.Append(int.Parse(data[0])+int.Parse(data[1]) + "\n");
        }

        Console.WriteLine(sb);
    }
}


