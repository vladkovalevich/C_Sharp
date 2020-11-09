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

		string[] _task7338(string[] input)
        {
            int number = Convert.ToInt32(input[0]);
            int n = 0;
            for (int i = 10; i < 99; i++)
            {
                int a = i / 10;
                int b = i % 10;
                int c = a + b;
                int ac_int = i * 2;
                int ab_int =  ac_int / 10;
                int abc_int = ac_int % 10;
                if (c == ab_int + abc_int)
                {
                    n += 1;
                }
            }
            return new[] { Convert.ToString(n) };
        }
    }
}

*/