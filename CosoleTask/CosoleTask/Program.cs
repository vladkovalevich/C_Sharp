using System;

namespace CosoleTask
{
	class Program
	{
		static void Main(string[] args)
		{
			_Task task = new _Task();
			task.run(7338);
            Console.ReadLine();
		}
	}
}



/*using System;

namespace CosoleTask
{	
	class Program
	{
		public delegate string[] OlympTask(string[] input);
		static void Main(string[] args)
		{
            execute(_task7338, 1);
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

        static string[] _task7338(string[] input)
        {
            int number = Convert.ToInt32(input[0]);
            int n = 0;
            for (int i = 10; i <= 99; i++)
            {
                if (calcSum(Convert.ToString(i)) == calcSum(Convert.ToString(i * number)))
                {
                    n += 1;
                }
            }
            return new[] { Convert.ToString(n+1) };
        }

        int calcSum(string input)
        {
           int c = 0; 
           for(int i = 0; i < input.Length; i++)
           {
               c = input[i];
           }
           return c;
        }
    }
}*/