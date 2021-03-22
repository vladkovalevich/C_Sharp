using System;

namespace CosoleTask
{
	class Program
	{
		static void Main(string[] args)
		{
			_Task task = new _Task();
			task.run(903);
            Console.ReadLine();
		}
	}
}



/*
using System;

namespace CosoleTask
{	
	class Program
	{
		public delegate string[] OlympTask(string[] input);
		static void Main(string[] args)
		{
            execute(_task903, 1);
		}
		static void execute(OlympTask task, int inputLines)
        {
			string[] inputArray = new string[inputLines];
			for(int i = 0; i < inputLines; i++)
            {
				inputArray[i] = Console.ReadLine();
			}

			string[] output = task(inputArray);
			foreach (string line in output)
				Console.WriteLine(line);
		}
       string[] _task903(string[] input)
 		 {
			string str = input[0];
			int a = Convert.ToInt32(Convert.ToString(str[0]));
			int b = Convert.ToInt32(Convert.ToString(str[1]));
			int c = Convert.ToInt32(Convert.ToString(str[2]));
			bool io = true;

			if (a > b && a > c)
			{
				return new[] { Convert.ToString(a) };

			}
			else if (b > a && b > c)
			{
				return new[] { Convert.ToString(b) };
			}
			else if (c > a && c > b)
			{
				return new[] { Convert.ToString(c) };
			}
			else 
			{
				return new[] { Convert.ToString("=") };
			}
	    }
    }
}
 */