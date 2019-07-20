using System;
using System.Collections;
using System.Collections.Generic;

namespace _11Algorithm {

	public class Order : IComparable
	{
		public int burger;
		public int frenchFry;

		public Order(string s1, string s2)
		{
			burger = int.Parse(s1);
			frenchFry = int.Parse(s2);
		}

		public override string ToString()
		{
			return string.Empty + burger + " " + frenchFry;
		}

		public int CompareTo(object a)
		{
			if (this.burger > ((Order)a).burger)
				return 1;
			else if (this.burger < ((Order)a).burger)
				return -1;
			else {

				if (this.frenchFry > ((Order)a).frenchFry)
					return 1;
				else if (this.frenchFry < ((Order)a).frenchFry)
					return -1;
				else
					return 0;
			}
		}
	}

	class Program {

        int numOfOrder;
        int numOfBurger;
        int numOfFrenchFry;

		ArrayList orderList = new ArrayList();


		static void Main(string[] args) {
            Program program = new Program();
            Console.WriteLine("CAU Burger 주문받기");

            // input : N 1~100 M 1~300 K 1~300
            // N개의 input : x,y 1~300 - M, K

            program.GetInputOfData();
			program.GetInputOfOrder();

        }

        void GetInputOfData() {
            // N M K를 배열에 담고
            string[] result = Console.ReadLine().Split(new char[] { ' ' });

            numOfOrder = int.Parse(result[0]);
            numOfBurger = int.Parse(result[1]);
            numOfFrenchFry = int.Parse(result[2]);

            Console.WriteLine(numOfOrder + " " + numOfBurger + " " + numOfFrenchFry);
        }

        void GetInputOfOrder() {

			for(int i = 0; i < numOfOrder; i++) {
				string[] tempString = Console.ReadLine().Split(new char[] { ' ' });
				Order order = new Order(tempString[0], tempString[1]);
				if(order.burger <= numOfBurger && order.frenchFry <= numOfFrenchFry) {
					orderList.Add(order);
				}
			}

			orderList.Sort();

			foreach(var i in orderList) {
				Console.WriteLine(i.ToString());
			}
        }

		void Calculate()
		{
			
		}
    }
}

