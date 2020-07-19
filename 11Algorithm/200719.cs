/*
https://www.acmicpc.net/problem/2741

그냥 For 돌렸더니 시간초과 나서 StringBuilder를 써주었다.
*/

using System;
using System.Text;

public class main {
	public static void Main() {
		
		int times = int.Parse(Console.ReadLine());
		StringBuilder sb = new StringBuilder();
		
		for (int i = 1; i <= times; i++) {
			sb.Append(i + "\n");
		}
		Console.WriteLine(sb);
	}
}

/*
https://www.acmicpc.net/problem/2742

위에꺼 그냥 반대로 돌림
*/
using System;
using System.Text;

public class main {
	public static void Main() {
		
		int times = int.Parse(Console.ReadLine());
		StringBuilder sb = new StringBuilder();
		
		for (int i = times; i > 0; i--) {
			sb.Append(i + "\n");
		}
		Console.WriteLine(sb);
	}
}

/*
https://www.acmicpc.net/problem/2438
*/
using System;
using System.Text;

public class main {
	public static void Main() {
		
		int times = int.Parse(Console.ReadLine());
		StringBuilder sb = new StringBuilder();
		
		for (int i = 0; i < times; i++) {
			for (int j = 0; j <= i; j++) {
                Console.Write("*");
            }
            Console.WriteLine();
		}
	}
}

/*
https://www.acmicpc.net/problem/2439
*/
using System;

public class main {
	public static void Main() {
		
		int times = int.Parse(Console.ReadLine());
		
		for (int i = 0; i < times; i++) {
            for(int j = times-1; j > i; j--) {
                Console.Write(" ");
            }
			for (int j = 0; j <= i; j++) {
                Console.Write("*");
            }
            Console.WriteLine();
		}
	}
}

/*
https://www.acmicpc.net/problem/10871
*/
using System;
using System.Text;

public class main {
	public static void Main() {
        
        string s = Console.ReadLine();
        string[] ss = s.Split();
        
        StringBuilder sb = new StringBuilder();

        int n = int.Parse(ss[0]);
        int x = int.Parse(ss[1]);

        ss = Console.ReadLine().Split(' ');

        for (int i = 0; i < n; i++) {
            if(int.Parse(ss[i]) < x)
                sb.Append(ss[i] + " ");    
        }

        Console.WriteLine(sb);
    }
}

/*
https://www.acmicpc.net/problem/1110
*/
using System;

public class main {
	public static void Main() {
        
        int n = int.Parse(Console.ReadLine());
        int newn = n;
        int count = 0;

        do {
            newn = newn % 10 * 10 + (newn % 10 + newn / 10) % 10;
            count++;
        } while(n != newn);

        Console.WriteLine(count);

    }
}

/*
https://www.acmicpc.net/problem/10039
*/
using System;

public class main {
	public static void Main() {
        
        int sum = 0;
        int temp;

        for(int i = 0; i < 5; i++) {
            temp = int.Parse(Console.ReadLine());

            if(temp < 40)
                sum += 40;
            else
                sum += temp;
        }

        Console.WriteLine(sum/5);
    }
}

/*
https://www.acmicpc.net/problem/5543
*/
using System;

public class main {
	public static void Main() {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        if(a > b)
            a = b;

        b = int.Parse(Console.ReadLine());
        if(a > b)
            a = b;

        b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        if(b > c)
            b = c;

        Console.WriteLine(a+b-50);
    }
}

/*
https://www.acmicpc.net/problem/10817
*/
using System;

public class main {
	public static void Main() {
        string[] s = new string[3];
        s = Console.ReadLine().Split();

        int[] temp = new int[3];
        temp[0] = int.Parse(s[0]);
        temp[1] = int.Parse(s[1]);
        temp[2] = int.Parse(s[2]);
        
        Array.Sort(temp);

        Console.WriteLine(temp[1]);
    }
}

/*
https://www.acmicpc.net/problem/2523
*/
using System;

public class main {
	public static void Main() {
        int n = int.Parse(Console.ReadLine());
        int i = 0;

        for (i = 0; i < n; i++) {
            for (int j = 0; j <= i; j++)
                Console.Write("*");
            Console.WriteLine("");
        }

        for (i -= 1; i > 0; i--) {
                    for (int j = 0; j < i; j++)
                Console.Write("*");
            Console.WriteLine("");
        }
    }
}

/*
https://www.acmicpc.net/problem/2446
*/
using System;

public class main {
	public static void Main() {
        int n = int.Parse(Console.ReadLine());
        int i = 0;

        for (i = 0; i < n; i++) {
            for (int j = 0; j < i; j++)
                Console.Write(" ");

            for (int j = 0; j < 2* (n - i) - 1; j++)
                Console.Write("*");

            Console.WriteLine("");
        }
        for (i -= 2; i >= 0; i--) {
            for (int j = 0; j < i; j++)
                Console.Write(" ");

            for (int j = 0; j < 2* (n - i) - 1; j++)
                Console.Write("*");

            Console.WriteLine("");
        }
    }
}


/*
https://www.acmicpc.net/problem/10996
*/
using System;
using System.Text;

public class main {
	public static void Main() {
        StringBuilder sb = new StringBuilder();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                if (j%2 == 0) {
                    sb.Append("*"); 
                } else {
                    sb.Append(" ");
                }
            }
            sb.Append("\n");
            for (int j = 0; j < n; j++) {
                if (j%2 != 0) {
                    sb.Append("*"); 
                } else {
                    sb.Append(" ");
                }
            }
            sb.Append("\n");
        }

        Console.WriteLine(sb);
    }
}



