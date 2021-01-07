using System;

namespace CosoleTask
{
	class Program
	{
		static void Main(string[] args)
		{
			_Task task = new _Task();
			task.run(927);
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
            execute(_task921, 1);
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
        static string[] _task927(string[] input)
		{
			int a = Convert.ToInt32(input[0]);
			int result = 0;
			for (int i = 1; i < a+1; i++)
			{
				string c = input[i];
				string[] d = c.Split(' ');
				int g = Convert.ToInt32(d[0]);
				double z = Convert.ToDouble(d[1]);
				if (z < 50.00)
				{
					result = result + g;
				}
			}
			return new[] { Convert.ToString(result) };
		}
    }
}
 */