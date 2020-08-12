using System;

namespace CosoleTask
{
	class Program
	{
		static void Main(string[] args)
		{
			//1 new
			/*
			string a = Console.ReadLine();
			string[] q = a.Split(" ");
			Console.WriteLine(q);
			*/

			//19 
			/*
			string a = Console.ReadLine();
			int result = 0;
			for (int i = 0; a.Length / 2 > i; i++)
			{
			    if (a[i] == a[a.Length - i - 1])
				{
					result += 1;
				}
			}
			if (a.Length % 2 != 0)
			{
				result += 1;
			}
			Console.WriteLine(result);
			*/

			//500 new
			
			int hz = Convert.ToInt32(Console.ReadLine());
			string[] z1 = Console.ReadLine().Split(" ");
			string[] z2 = Console.ReadLine().Split(" ");

			int L = Convert.ToInt32(z1[0]);
			int W = Convert.ToInt32(z1[0]);
			int H = Convert.ToInt32(z1[0]);

			int L1 = Convert.ToInt32(z2[0]);
			int W1 = Convert.ToInt32(z2[0]);
			int H1 = Convert.ToInt32(z2[0]);

			if (L >= 1000 || W >= 1000 || H >= 1000 || hz >= 1000) 
			{
				Console.WriteLine("error");
				return;
			}
			if (L1 >= 1000 || W1 >= 1000 || H1 >= 1000)
			{
				Console.WriteLine("error");
				return;
			}
			double s = 2 * (W * L) * H;
			s = s / 16;
			double result = Math.Ceiling(s);
			Console.WriteLine(result);

			//8801
			/*
			int n = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(Convert.ToString(n + 1));
			*/

			//8802
			/*
			int n = Convert.ToInt32(Console.ReadLine())
			Console.WriteLine(Convert.ToString(n - 1));
			*/

			//8803
			/*
			string a1 = Console.ReadLine();
			Console.WriteLine(Convert.ToInt32(a1) + 1);
			*/

			//8804
			/*
			string a = Console.ReadLine();
			string b = Console.ReadLine();
			Console.WriteLine(Convert.ToInt32(a)+Convert.ToInt32(b));
			*/

			//8805 
			/*
			string a4 = Console.ReadLine();
			string[] d2 = a4.Split(" ");
			int resultd2 = Convert.ToInt32(d2[0]) + Convert.ToInt32(d2[1]);
			Console.WriteLine(resultd2);
			*/

			//8806
			/*
			string a3 = Console.ReadLine();
			string[] d1 = a3.Split(" ");
			int resultd1 = Convert.ToInt32(d1[0]) + Convert.ToInt32(d1[1]);
			Console.WriteLine(resultd1);
			*/

			//8807
			/*
			string a2 = Console.ReadLine();
			Console.WriteLine(Convert.ToInt32(a2) - (Convert.ToInt32(a2) * 2));
			*/

			//8808 new
			/*
			string a = Console.ReadLine();
			string b = Console.ReadLine();
			Console.WriteLine(Convert.ToInt32(a) - Convert.ToInt32(b));
			*/

			//8809 
			/*
			string s = Console.ReadLine();
			string[] n = s.Split(" ");
			Console.WriteLine(Convert.ToString(Convert.ToInt32(n[0]) - Convert.ToInt32(n[1])));
			*/

			//8811
			/*
			string a4 = Console.ReadLine();
			string[] d2 = a4.Split(" ");
			int resultd2 = Convert.ToInt32(d2[0]) * Convert.ToInt32(d2[1]);
			Console.WriteLine(resultd2);
			*/

			//8814
			/*
			double n = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine(Convert.ToString(n * 4 + " " + n * n));
			Console.ReadLine();
			*/

			//8816
			/*
			string a = Console.ReadLine();
			string b = Console.ReadLine();
			Console.WriteLine(Convert.ToInt32(a) ^ Convert.ToInt32(b));
			*/

		}
	}
}
