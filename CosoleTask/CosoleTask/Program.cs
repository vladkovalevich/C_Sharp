using System;

namespace CosoleTask
{
	class Program
	{
		static void Main(string[] args)
		{
			_Task task = new _Task();
			task.run(-1);
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
            execute(_task116, 1);
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

        static string[] _task116(string[] input)
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
    }
}
 */