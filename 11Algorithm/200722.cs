/*
https://www.acmicpc.net/problem/4344

Console.Write()에서 format 지정하기
*/

using System;
using System.Text;

public class main {
	public static void Main() {
        int numb = int.Parse(Console.ReadLine());
        float ave = 0, perc = 0;

        string s;
        string[] ss;
        int[] nn;

        for(int i = 0; i < numb; i++) {
            s = Console.ReadLine();
            ss = s.Split();

            nn = new int[int.Parse(ss[0])+1];
            nn[0] = int.Parse(ss[0]);

            for(int j = 1; j <= nn[0] ; j++) {
                nn[j] = int.Parse(ss[j]);
                ave += nn[j];
            }

            ave = ave / nn[0];

            for(int j = 1; j <= nn[0]; j++) {
                if(nn[j] > ave) {
                    perc++;
                }
            }

            perc = perc / nn[0] * 100;

            Console.WriteLine("{0:F3}%", perc);
            perc = 0;
            ave = 0;
        }
    }
}
