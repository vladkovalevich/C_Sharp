﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CosoleTask
{
    class _Task
    {
        public delegate string[] OlympTask(string[] input);
        void test(OlympTask task, string[] input, string[] expectedOutput)
        {
            var realOutput = task(input);
            if (realOutput.Length == expectedOutput.Length)
            {
                for (int i = 0; i < realOutput.Length; i++)
                {
                    if (realOutput[i] != expectedOutput[i])
                    {
                        Console.WriteLine("FAIL (expected: {0}, actual {1}", expectedOutput[i], realOutput[i]);
                        return;
                    }
                }
                Console.WriteLine("PASS");
            }
            else
            {
                Console.WriteLine("FAIL invalid length");
            }
        }

        void execute(OlympTask task, int inputLines)
        {
            string[] inputArray = new string[inputLines];
            for (int i = 0; i < inputLines; i++)
            {
                inputArray[i] = Console.ReadLine();
            }

            string[] output = task(inputArray);
            foreach (string line in output)
                Console.WriteLine(line);
        }

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
                case 7338:
                    task7338();
                    break;
				case 19:
					task19();
					break;
				case 907:
					task907();
					break;
                case 116:
                    task116();
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
				case -1:
					task_1();
					break;
				default:
					Console.WriteLine("no such task");
					break;
			}
        }

		/*----Задачи----*/
	    void task_1() 
		{
			test(_task_1, new string[] { "Red 5", "Blue 5", "White 3", "end"}, new string[] { "Red 5", "Blue 5", "White 3"});
			test(_task_1, new string[] { "Red 5", "Blue 5", "Red 4", "White 3", "end" }, new string[] { "Red 9", "Blue 5", "White 3" });
		}
		string[] _task_1(string[] input) 
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
			int index = 0;
            while (true)
            { 
				string line = input[index];
                if (line == "end")
                {
				    string[] array;
					array = new string[dict.Count]; 
					for (int i = 0; i < dict.Count; i++)
                    {
						KeyValuePair<string, int> pair = dict.ElementAt(i);

						string key = pair.Key;
                        int value = pair.Value;
						array[i] = key + " " + value;

					}
                    return array;
                }
                else
                {
                    string[] str = line.Split();
                    string color = str[0];
                    int count = Convert.ToInt32(str[1]);
                    if(dict.ContainsKey(color))
                    {
                      //  dict.
                    }
                    else
                    {
                        dict.Add(color, count);
                    }
					index++;
                }
            }
        }



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
            test(_task902, new string[] { "12" }, new string[] { "High" });
            test(_task902, new string[] { "6" }, new string[] { "Average" });
            test(_task902, new string[] { "3" }, new string[] { "Initial" });
            test(_task902, new string[] { "8" }, new string[] { "Sufficient" });

            execute(_task902, 1);
        }

        string[] _task902(string[] input)
        {
            string[] res = new string[1];
            int n = Convert.ToInt32(input[0]);
            if (n <= 3)
            {
                res[0] = "Initial";
            }
            else if (n <= 6)
            {
                res[0] = "Average";
            }
            else if (n <= 9)
            {
                res[0] = "Sufficient";
            }
            else
            {
                res[0] = "High";
            }
            return res;
        }

		void task904() 
		{
            int n = Convert.ToInt32(Console.ReadLine());
            string[] str1 = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                if (Convert.ToInt32(str1[i]) >= 0)
                {
                    Console.Write(Convert.ToString(Convert.ToInt32(str1[i]) + 2));
                    if (i != n - 1)
                    {
                        Console.Write(" ");
                    }
                }
                else
                {
                    Console.Write(str1[i]);
                    if(i != n-1)
                    {
                        Console.Write(" ");
                    }
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
            /*test(_task583, new string[] { "08:00", "10:00", "12:00", "18:00" }, new string[] { "04:00" });
            test(_task583, new string[] { "23:00", "01:00", "05:00", "11:00"}, new string[] { "04:00" });
            test(_task583, new string[] { "21:00", "23:00", "03:00", "09:00"}, new string[] { "04:00" });
            test(_task583, new string[] { "10:00", "12:20", "01:00", "07:20"}, new string[] { "04:20" });
			test(_task583, new string[] { "10:00", "09:00", "01:00", "04:00" }, new string[] { "01:00" });
			test(_task583, new string[] { "10:00", "10:00", "01:00", "05:00" }, new string[] { "02:00" });
			test(_task583, new string[] { "23:00", "01:00", "22:00", "04:00" }, new string[] { "04:00" });*/
            test(_task583, new string[] { "23:00", "21:00", "22:00", "00:00" }, new string[] { "24:00" });
		}
		string[] _task583(string[] input)
        {
            var a1 = DateTime.Parse(input[0]);
            var b1 = DateTime.Parse(input[1]);

            var a2 = DateTime.Parse(input[2]);
            var b2 = DateTime.Parse(input[3]);

            var Odessa = b2 - a1;
            var Berlin_paking = a2 - b1;
            if(Odessa < TimeSpan.Zero)
            {
                Odessa += TimeSpan.FromDays(1);
            }
            if (Berlin_paking < TimeSpan.Zero)
            {
                Berlin_paking += TimeSpan.FromDays(1);
            }
			
            for(int i = 0; Odessa <= Berlin_paking; i++)
            {
                Odessa += TimeSpan.FromDays(1);
            }        
            var result = TimeSpan.FromSeconds((Odessa.TotalSeconds - Berlin_paking.TotalSeconds) / 2);
            return new[] {result.ToString(@"hh\:mm")};
        }

		void task5()
		{
			int n = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(n * n);
		}
        
        void task8()
        {
            test(_task8, new string[] { "4" }, new[] { "12" });

            execute(_task8, 1);
        }

        string[] _task8(string[] input)
        {
            int n = Convert.ToInt32(input[0]);
            double result = 2 * Math.Floor(Math.Sqrt(n)) + Math.Ceiling(n / Math.Floor(Math.Sqrt(n)));
            return new[] { Convert.ToString(result) };
        }

        void task7338()
        {
            test(_task7338, new string[] { "2" }, new[] { "10" });
            execute(_task7338 , 1);
        }
        string[] _task7338(string[] input)
        {
			int tmp = calcSum(123456);

			int number = Convert.ToInt32(input[0]);
            int n = 0;
            for (int i = 10; i <= 99; i++)
            {
                if (calcSum(i) == calcSum(i * number))
                {
                    n += 1;
                }
            }
            return new[] { Convert.ToString(n) };
        }

        int calcSum(int input)
        {
           int result = 0;
		   while (input > 0)
		   {
				int a = input % 10;
				int b = input / 10;
				result += a;
				input = b;
		   }
           return result;
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
            test(_task907, new string[] { "5", "6 7.5 2.1 2.0 0" }, new[] { "3 2.10" });
            test(_task907, new string[] { "5", "6 7.5 5.1 7.0 80" }, new[] { "Not Found" });
            test(_task907, new string[] { "5", "6 7.5 2.6 2.5 2.4" }, new[] { "4 2.50" });

            execute(_task907, 2);
        }

        string[] _task907(string[] input)
        {
            string[] numbers = input[1].Split();
            for (int i = 0; numbers.Length > i; i++)
            {
                double value = Convert.ToDouble(numbers[i]);
                if (value <= 2.5)
                {
                    string result = String.Format("{0} {1:f2}", i + 1, value);
                    return new[] { result };
                }
            }
            return new[] { "Not Found" };
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
           test(_task116, new string[] { "11", "3" }, new[] { "13" });
           execute(_task116, 2);
        }

        string[] _task116(string[] input)
        {
            string[] numbers = input;
            int a = Convert.ToInt32(numbers[0]);
            int c = Convert.ToInt32(numbers[1]);

            for (int i = 0; i < c; i++)
            {
                int f = Convert.ToInt32(Convert.ToString(a)+Convert.ToString(a));
                if (f % c == 0) 
                {
                    return new[] { Convert.ToString(c) };
                }
                else
                {
                    a++;
                }
            }
            return new[] { "Not Found" };
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
