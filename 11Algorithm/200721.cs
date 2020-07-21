/*
https://www.acmicpc.net/problem/10818
*/
using System;
using System.Text;

public class main {
	public static void Main() {
        int n = int.Parse(Console.ReadLine());

        string[] ns = new string[n];
        ns = Console.ReadLine().Split(" ");

        int[] nss = new int[n];

        for(int i = 0; i < n; i++) {
            nss[i] = int.Parse(ns[i]);
        }

        int max = nss[0];
        int min = nss[0];

        for(int i = 0; i < n; i++) {
            if(max < nss[i])
                max = nss[i];
            if(min > nss[i])
                min = nss[i];
        }

        Console.WriteLine(min + " " + max);

    }
}

/*
https://www.acmicpc.net/problem/2562
*/
using System;
using System.Text;

public class main {
	public static void Main() {
        int[] ns = new int[9];
        int maxIndex = 0;

        for(int i = 0; i < 9; i++) {
            ns[i] = int.Parse(Console.ReadLine());
            if(ns[maxIndex] < ns[i])
                maxIndex = i;
        }

        Console.WriteLine(ns[maxIndex] + "\n" + (maxIndex+1));
    }
}

/*
https://www.acmicpc.net/problem/2577
*/
using System;
using System.Text;

public class main {
	public static void Main() {
        int[] ns = new int[10] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        long n = int.Parse(Console.ReadLine());
        n = int.Parse(Console.ReadLine()) * n;
        n = int.Parse(Console.ReadLine()) * n;

        while (n > 0) {
            ns[n%10]++;
            n = n / 10;
        }

        for(int i = 0; i < 10; i++) {
            Console.WriteLine(ns[i]);
        }
    }
}

/*
https://www.acmicpc.net/problem/3052
*/
using System;
using System.Text;

public class main {
	public static void Main() {
        int[] ns = new int[42];
        int numb;
        int count = 0;

        for(int i = 0; i < 10; i++) {
            numb = int.Parse(Console.ReadLine());

            ns[numb%42]++;
        }

        for(int i = 0; i < 42; i++) {
            if(ns[i] != 0)
                count++;
        }

        Console.WriteLine(count);
    }
}

/*
https://www.acmicpc.net/problem/1546
*/
using System;
using System.Text;

public class main {
	public static void Main() {
        int numb = int.Parse(Console.ReadLine());
        float[] score = new float[numb];
        string[] scoreS = new string[numb];

        float max = 0;

        scoreS = Console.ReadLine().Split(" ");

        for(int i = 0; i < numb; i++) {
            score[i] = float.Parse(scoreS[i]);

            if(max < score[i])
                max = score[i];
        }

        float newAve = 0;

        for(int i = 0; i < numb; i++) {
            score[i] = score[i] / max * 100;
            newAve += score[i];
        }

        newAve = newAve / numb;

        Console.WriteLine(newAve);
    }
}

/*
https://www.acmicpc.net/problem/8958
*/
using System;
using System.Text;

public class main {
	public static void Main() {
        int numb = int.Parse(Console.ReadLine());
        string s;
        char[] ss;

        int score = 0, plusScore = 0;

        for(int i = 0; i < numb; i++) {
            s = Console.ReadLine();
            ss = s.ToCharArray();

            for (int j = 0; j < ss.Length; j++) {
                if(ss[j] == 'O') {
                    plusScore++;
                    score += plusScore;
                } else {
                    plusScore = 0;
                }
            }

            Console.WriteLine(score);
            score = 0;
            plusScore = 0;
        }
    }
}
