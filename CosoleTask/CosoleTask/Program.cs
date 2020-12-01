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
            execute(_task922, 1);
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

        static string[] _task922(string[] input)
        {
            int a = Convert.ToInt32(input[0]);
            string[] b = input[1].Split(' ');
            string result = "";
            for (int i = 1; i < a; i++)
            {
                result += b[a - i] + ' ';
            }

            return new[] { Convert.ToString(result + "1") };
        }
    }
}
 */