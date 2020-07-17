/*
입출력을 여러개 풀었는데, 갑자기 pc가 리셋되면서 날아감;;; 이래서 맥을 써야해..
*/

/*
https://www.acmicpc.net/problem/10172
*/

using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("|\\_/|");
    Console.WriteLine ("|q p|   /}");
    Console.WriteLine ("( 0 )\"\"\"\\");
    Console.WriteLine ("|\"^\"`    |");
    Console.WriteLine ("||_/=\\\\__|");

  }
}

/*
https://www.acmicpc.net/problem/1001
*/

using System;

class MainClass {
  public static void Main (string[] args) {
    string s = Console.ReadLine();

    string[] ss = s.Split();

    Console.WriteLine(int.Parse(ss[0]) - int.Parse(ss[1]));
  }
}

/*
https://www.acmicpc.net/problem/10998
*/
using System;

class MainClass {
  public static void Main (string[] args) {
    string s = Console.ReadLine();

    string[] ss = s.Split();

    Console.WriteLine(int.Parse(ss[0]) * int.Parse(ss[1]));
  }
}

/*
https://www.acmicpc.net/problem/1008
*/
using System;

class MainClass {
  public static void Main (string[] args) {
    string s = Console.ReadLine();

    string[] ss = s.Split();

    Console.WriteLine(double.Parse(ss[0]) / double.Parse(ss[1]));
  }
}

/*
https://www.acmicpc.net/problem/10869
*/
using System;

class MainClass {
  public static void Main (string[] args) {
    string s = Console.ReadLine();

    string[] ss = s.Split();

    Console.WriteLine(int.Parse(ss[0]) + int.Parse(ss[1]));
    Console.WriteLine(int.Parse(ss[0]) - int.Parse(ss[1]));
    Console.WriteLine(int.Parse(ss[0]) * int.Parse(ss[1]));
    Console.WriteLine(int.Parse(ss[0]) / int.Parse(ss[1]));
    Console.WriteLine(int.Parse(ss[0]) % int.Parse(ss[1]));

  }
}

/*
https://www.acmicpc.net/problem/10430
*/
using System;

class MainClass {
  public static void Main (string[] args) {
    string s = Console.ReadLine();
    string[] ss = s.Split();

    int A = int.Parse(ss[0]);
    int B = int.Parse(ss[1]);
    int C = int.Parse(ss[2]);

    Console.WriteLine((A+B)%C);
    Console.WriteLine(((A%C) + (B%C))%C);
    Console.WriteLine((A*B)%C);
    Console.WriteLine(((A%C) * (B%C))%C);

  }
}

/*
https://www.acmicpc.net/problem/2588

더 잘 할 수 있었지만, 귀찮으므로 그냥 이렇게 했다.
*/
using System;

class MainClass {
  public static void Main (string[] args) {
    string a = Console.ReadLine();
    string b = Console.ReadLine();

    int aa = 100*(a[0] - '0') + 10*(a[1]-'0') + (a[2] - '0');
    int bb = 100*(b[0]-'0') + 10*(b[1]-'0') + b[2]-'0';

    Console.WriteLine(aa * (bb%10));
    Console.WriteLine(aa * (bb/10 % 10));
    Console.WriteLine(aa * (bb/100 % 10));

    Console.WriteLine(aa * bb);
  }
}
