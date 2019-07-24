using System;
using System.Collections;
using System.Collections.Generic;

namespace _11Algorithm {

	class Program {

		int T = 0;
		int N = 0;

		ArrayList arrayList = new ArrayList();

		static void Main() {
			Program program = new Program();

			program.GetData();
			program.CalculaterData();
		}

		void GetData() {
			T = int.Parse(Console.ReadLine());
			for(int i = 0; i < T; i++) {
				arrayList.Add(int.Parse(Console.ReadLine()));
			}
		}

		void CalculaterData()
		{
			for(int i = 0; i < T; i++) {
				Console.WriteLine(string.Empty + RecFunc((int)arrayList[i]));
			}
		}

		int RecFunc(int N)
		{
			ulong temp = 3;
			int k = 1;
			int Ntimes = 3;
			if (N < 3) {
				return 1;
			}

			while (N > Ntimes) {
				while (temp >= (ulong) k * 3)
					k++;
				temp += (ulong) k;
				Ntimes++;
			}

			return k;
		}
	}
}

