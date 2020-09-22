using System;
using System.Collections.Generic;
using System.Text;

namespace CosoleTask
{
    class _Task
    {
        public void run(int id)
        {
            switch (id) 
            {
				case 1:
					task1();
					break;
				case 2:
					task2();
					break;
				case 0:
					task();
					break;
				case 5:
					task5();
					break;
				case 7366:
					task7366();
					break;
				case 19:
					task19();
					break;
				case 907:
					task907();
					break;
				case 8800:
					task8800();
					break;
				case 8801:
					task8801();
					break;
				case 8802:
					task8802();
					break;
				case 8803:
					task8803();
					break;
				case 8804:
					task8804();
					break;
				case 8805:
					task8805();
					break;
				case 8806:
					task8806();
					break;
				case 8807:
					task8807();
					break;
				case 8808:
					task8808();
					break;
				case 8809:
					task8809();
					break;
				case 8810:
					task8810();
					break;
				case 88011:
					task8811();
					break;
				case 8812:
					task8805();
					break;
				case 8813:
					task8805();
					break;
				case 8814:
					task8805();
					break;
				case 8816:
					task8816();
					break;
				case 500:
					task8805();
					break;
				default:
					Console.WriteLine("no such task");
					break;
			}
        }

		/*----Задачи----*/



		void task1()
		{
			string a = Console.ReadLine();
			string[] q = a.Split(" ");
			Console.WriteLine(q);
		}
		void task2()
		{
			int n = Console.ReadLine().Length;
			Console.WriteLine(n + 1);
		}

		void task()
		{

		}

		void task5()
		{
			int n = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(n * n);
		}

		void task7366()
		{
			/*Console.log(n/86400 + " " + (n%86400)/3600 + " " + ((n%86400)%3600)/60 + " " + n%60);*/
			int n = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(n / 86400 + " " + (n % 86400) / 3600 + " " + ((n % 86400) % 3600) / 60 + " " + n % 60);
		}


		void task19()
		{
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
		}
		void task907()
		{
			//todo 50%
			int howNumbers = Convert.ToInt32(Console.ReadLine());
			string[] numbers = Console.ReadLine().Split();
			string result = " ";
			int result1 = 0;
			for (int i = 0; howNumbers > i;)
			{
				i++;
				if (Convert.ToDouble(numbers[i]) < 2.5)
				{
					result = numbers[i];
					result1 = i;
					Console.WriteLine(Convert.ToString(i) + " " + result);
					break;
				}
			}
			if (result1 == 0)
			{
				Console.WriteLine("Not Found");
			}
		}
		void task8800()
		{
			Console.WriteLine("Hello, Python!");
		}
		void task8801()
		{
			int n = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(Convert.ToString(n + 1));
		}

		void task8802()
		{
			int n = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(Convert.ToString(n - 1));
		}
		void task8803()
		{
			string a1 = Console.ReadLine();
			Console.WriteLine(Convert.ToInt32(a1) + 1);
		}

		void task8804()
		{
			string a = Console.ReadLine();
			string b = Console.ReadLine();
			Console.WriteLine(Convert.ToInt32(a) + Convert.ToInt32(b));
		}

		void task8805()
		{
			string a4 = Console.ReadLine();
			string[] d2 = a4.Split(" ");
			int resultd2 = Convert.ToInt32(d2[0]) + Convert.ToInt32(d2[1]);
			Console.WriteLine(resultd2);
		}

		void task8806()
		{
			string a3 = Console.ReadLine();
			string[] d1 = a3.Split(" ");
			int resultd1 = Convert.ToInt32(d1[0]) + Convert.ToInt32(d1[1]);
			Console.WriteLine(resultd1);
		}

		void task8807()
		{
			string a2 = Console.ReadLine();
			Console.WriteLine(Convert.ToInt32(a2) - (Convert.ToInt32(a2) * 2));
		}

		void task8808()
		{
			string a = Console.ReadLine();
			string b = Console.ReadLine();
			Console.WriteLine(Convert.ToInt32(a) - Convert.ToInt32(b));
		}

		void task8809()
		{
			string s = Console.ReadLine();
			string[] n = s.Split(" ");
			Console.WriteLine(Convert.ToString(Convert.ToInt32(n[0]) - Convert.ToInt32(n[1])));
		}

		void task8810()
		{
			string[] n = Console.ReadLine().Split(" ");
			Console.WriteLine(Convert.ToInt32(n[0]) + Convert.ToInt32(n[1]) - Convert.ToInt32(n[2]));
		}

		void task8811()
		{
			string a4 = Console.ReadLine();
			string[] d2 = a4.Split(" ");
			int resultd2 = Convert.ToInt32(d2[0]) * Convert.ToInt32(d2[1]);
			Console.WriteLine(resultd2);
		}

		void task8812()
		{
			string[] a = Console.ReadLine().Split(" ");
			int P = 2 * (Convert.ToInt32(a[0]) + Convert.ToInt32(a[1]));
			int S = Convert.ToInt32(a[0]) * Convert.ToInt32(a[1]);
			Console.WriteLine(Convert.ToString(P) + " " + Convert.ToString(S));
		}
		void task8813()
		{

		}

		void task8814()
		{
			double n = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine(Convert.ToString(n * 4 + " " + n * n));
			Console.ReadLine();
		}

		void task8816()
		{
			string a = Console.ReadLine();
			string b = Console.ReadLine();
			Console.WriteLine(Convert.ToInt32(a) ^ Convert.ToInt32(b));
		}


		void task500()
		{
			int orders = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i < orders; i++)
			{
				string[] z1 = Console.ReadLine().Split(" ");

				int L = Convert.ToInt32(z1[0]);
				int W = Convert.ToInt32(z1[1]);
				int H = Convert.ToInt32(z1[2]);

				if (L > 1000 || W > 1000 || H > 1000)
				{
					Console.WriteLine("error");
					return;
				}

				double s = 2 * (W + L) * H;
				s = s / 16;
				double result = Math.Ceiling(s);
				Console.WriteLine(result);
			}
		}
	}
}
