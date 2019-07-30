using System;
using System.Collections;
using System.Collections.Generic;

namespace _11Algorithm {

	class Program {

		static void Main() {
			long N = long.Parse(Console.ReadLine());
			int[] array = new int[N+1];

			array[1] = 0;

			for(int i = 2; i <= N; i++) {
				array[i] = array[i - 1] + 1;
				if(i%2 == 0) {
					array[i] = (int) MathF.Min(array[i], array[i / 2] + 1);
				}
				if(i%3 == 0) {
					array[i] = (int) MathF.Min(array[i], array[i / 3] + 1);
				}
			}

			Console.WriteLine(array[N]);
		}
	}
}

