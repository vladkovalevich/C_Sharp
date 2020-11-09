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

		static string[] _task583(string[] input)
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
            if (Odessa < Berlin_paking)
            {
                Odessa += TimeSpan.FromDays(1);
            }
         
            var result = TimeSpan.FromSeconds((Odessa.TotalSeconds - Berlin_paking.TotalSeconds) / 2);
            return new[] {result};
        }
    }
}

*/