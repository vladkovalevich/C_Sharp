using System;

namespace ConsoleTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Следующее
            /*int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Convert.ToString(n + 1));*/

            //Предыдущее
            /*int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Convert.ToString(n - 1));*/

            //Разница чисел 
            /*string s = Console.ReadLine();
            string[] n = s.Split("");
            Console.WriteLine(Convert.ToString(Convert.ToInt32(n[0]) - Convert.ToInt32(n[1])));*/

            //P и S
            double n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Convert.ToString(n*4 + " " + n*n)); 
             
        }

    }
}
