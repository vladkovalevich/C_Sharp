using System;

namespace CosoleTask
{
	class Program
	{
		static void Main(string[] args)
		{
			_Task task = new _Task();
			task.run(8);
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
            execute(_task8, 1);
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

        static string[] _task8(string[] input)
        {
            double n = Convert.ToInt32(input[0]);
            double result = 0; 

            double sqrt = Math.Sqrt(n);
            n = sqrt;
            result = n * (n + 1) * 2;

            return new[] { Convert.ToString(Math.Ceiling(result)) };
        }
    }
}
 */