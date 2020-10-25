using System;

namespace CosoleTask
{
	class Program
	{
		static void Main(string[] args)
		{
			_Task task = new _Task();
			task.run(583);
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
			execute(_task907, 2);
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

		static string [] _task907(string [] input)
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
    }
}

*/