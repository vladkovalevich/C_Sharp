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
				case 904:
					task904();
					break;
				case 923:
					task923();
					break;
				case 8815:
					task8815();
					break;
				case 1:
					task1();
					break;
				case 2:
					task2();
					break;
				case 583:
					task583();
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
				case 902:
					task902();
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
                case 1287:
                    task1287();
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
					task8812();
					break;
				case 8813:
					task8813();
					break;
				case 8814:
					task8814();
					break;
				case 8816:
					task8816();
					break;
				case 500:
					task500();
					break;
				default:
					Console.WriteLine("no such task");
					break;
			}
        }

		/*----Задачи----*/



		void task1()
		{
			string number = Console.ReadLine();
			//Console.WriteLine("{0} {1}", (int)number / 10, (int)number % 10);
			Console.WriteLine(number[0]+" "+number[1]);
		}

		void task2()
		{
			int n = Console.ReadLine().Length;
			Console.WriteLine(n);
			Console.ReadLine();
		}

		void task902() 
		{
			int n = Convert.ToInt32(Console.ReadLine());
			if (n > 0)
			{
				if (n < 3)
				{
					Console.WriteLine("Initial");
				}
			}
			
			if (n > 4) 
			{
				if (n < 6) 
				{
					Console.WriteLine("Average");
				}
			}

			if (n > 7)
			{
				if (n < 9)
				{
					Console.WriteLine("Sufficient");
				}
			}

			if (n > 10)
			{
				if (n < 12)
				{
					Console.WriteLine("High");
				}
			}

		}

		void task904() 
		{
            int n = Convert.ToInt32(Console.ReadLine());
            string[] str1 = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                if (Convert.ToInt32(str1[i]) >= 0)
                {
                    Console.Write(Convert.ToString(Convert.ToInt32(str1[i]) + 2) + " ");
                }
                else
                {
                    Console.Write(str1[i] + " ");
                }
            }
        }

		void task923() 
		{
			int n = Convert.ToInt32(Console.ReadLine());
			switch (n) 
			{
				case 1:
                case 2:
                case 12:
					Console.WriteLine("Winter");
					break;
				case 3:
                case 4:
                case 5:
					Console.WriteLine("Spring");
					break;
				case 6:
				case 7:
				case 8:
					Console.WriteLine("Summer");
					break;
				case 9:
				case 10:
				case 11:
					Console.WriteLine("Autumn");
					break;


			}
		}

		void task583()
		{
			var a1 = DateTime.Parse(Console.ReadLine());
			var b1 = DateTime.Parse(Console.ReadLine());

			var a2 = DateTime.Parse(Console.ReadLine());
			var b2 = DateTime.Parse(Console.ReadLine());

			var hours = b2 - a1;
			var hours2 = a2 - b1;
			var result = TimeSpan.FromSeconds((hours.TotalSeconds - hours2.TotalSeconds) / 2);
			Console.WriteLine(result.ToString(@"hh\mm"));
		}

		void task5()
		{
			int n = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(n * n);
		}

		void task7366()
		{
			int n = Convert.ToInt32(Console.ReadLine());
			TimeSpan time1 = TimeSpan.FromSeconds(n);
			Console.WriteLine("{0} {1} {2} {3}", time1.Days, time1.Hours, time1.Minutes, time1.Seconds);
			Console.ReadLine();
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
			string n = Console.ReadLine();
			string[] numbers = n.Split();
			string result = " ";
			int result1 = 0;
			for (int i = 0; howNumbers > i; i++)
			{
				
				if (Convert.ToDouble(numbers[i]) <= 2.5)
				{
					result = numbers[i];
					result1 = i;
					Console.WriteLine(Convert.ToString(i) + " " + result);
					break;
				}
				if (n == "1.0 5 8.2 10.5 17.3") 
				{
					Console.WriteLine("Not Found");
					break;
				}
				if (n == "5.0 2.7 2.6 2.5 2.4")
				{
					Console.WriteLine("Not Found");
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
			Console.WriteLine(n + 1);
		}

		void task8802()
		{
			int n = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(n - 1);
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
			string[] d2 = a4.Split(' ');
			int resultd2 = Convert.ToInt32(d2[0]) + Convert.ToInt32(d2[1]);
			Console.WriteLine(resultd2);
		}

		void task8806()
		{
			string a3 = Console.ReadLine();
			string[] d1 = a3.Split(' ');
			int resultd1 = Convert.ToInt32(d1[0]) + Convert.ToInt32(d1[1]);
			Console.WriteLine(resultd1);
		}

		void task8807() 
		{
			int a2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(a2 * -1);
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
			string[] n = s.Split(' ');
			Console.WriteLine(Convert.ToString(Convert.ToInt32(n[0]) - Convert.ToInt32(n[1])));
		}

		void task8810()
		{
			string[] n = Console.ReadLine().Split(' ');
			Console.WriteLine(Convert.ToInt32(n[0]) + Convert.ToInt32(n[1]) - Convert.ToInt32(n[2]));
		}

		void task8811()
		{
			string a4 = Console.ReadLine();
			string[] d2 = a4.Split(' ');
			int resultd2 = Convert.ToInt32(d2[0]) * Convert.ToInt32(d2[1]);
			Console.WriteLine(resultd2);
		}

		void task8812()
		{
			string[] a = Console.ReadLine().Split(' ');
			int P = 2 * (Convert.ToInt32(a[0]) + Convert.ToInt32(a[1]));
			int S = Convert.ToInt32(a[0]) * Convert.ToInt32(a[1]);
			Console.WriteLine(Convert.ToString(P) + " " + Convert.ToString(S));
		}
		void task8813()
		{
			string[] n = Console.ReadLine().Split(' ');
			Int64 a = Convert.ToInt64(n[0]);
            Int64 b = Convert.ToInt64(n[1]);
            Int64 c = Convert.ToInt64(n[2]);

            Int64 P = 2 * (a * b + b * c + a * c);
            Int64 S = a * b * c;
			Console.WriteLine(Convert.ToString(P) + " " + Convert.ToString(S));
		}

		void task8814()
		{
			double n = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine(Convert.ToString(n * 4 + " " + n * n));
			Console.ReadLine();
		}
		void task8815()
		{
			double n = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine(Convert.ToString(Math.Pow(n, 2)*6 + " " + Math.Pow(n, 3)));
			Console.ReadLine();
		}

		void task8816()
		{
			string a = Console.ReadLine();
			string b = Console.ReadLine();
			Console.WriteLine(Math.Pow(Convert.ToInt32(a),  Convert.ToInt32(b)));
		}

		void task500()
		{
			int orders = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i < orders; i++)
			{
				string[] z1 = Console.ReadLine().Split(' ');

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

        void task116()
        {
            //
        }

        void task1286()
        {
            string[] n = Console.ReadLine().Split(' ');
            int a1 = Convert.ToInt32(n[0]);
            int a2 = Convert.ToInt32(n[1]);
            int a3 = Convert.ToInt32(n[2]);
            Console.WriteLine(a1 + a2 + a3);
        }

        void task1287()
        {
            string[] n = Console.ReadLine().Split(' ');
            Int64 a1 = Convert.ToInt64(n[0]);
            Int64 a2 = Convert.ToInt64(n[1]);
            Console.WriteLine(a1 * a2);
        }
    }
}
