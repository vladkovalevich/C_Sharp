using System;

namespace CosoleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Следующее
            /*int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Convert.ToString(n + 1));*/

            //Предыдущее
            /*int n = Convert.ToInt32(Console.ReadLine())
             * Console.WriteLine(Convert.ToString(n - 1));*/

            //Разница чисел 
            /*string s = Console.ReadLine();
            string[] n = s.Split("");
            Console.WriteLine(Convert.ToString(Convert.ToInt32(n[0]) - Convert.ToInt32(n[1])));*/

            //P и S
            /*double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Convert.ToString(n * 4 + " " + n * n));

            Console.ReadLine();*/

            //19 todo 100%
               // string a = Console.ReadLine();
          //      int result = 0;
            //    for (int i = 0; a.Length / 2 < 0; i++)
              //  {
      //          if (a[i] == a.Length - (i+1)) 
        //            {
          //              result += 1;
            //        }
              //  }
               // if (a.Length % 2 != 0) {
                   // result += 1;
               // }
                //Console.WriteLine(result);

            //8803 100%
            //string a1 = Console.ReadLine();
            //Console.WriteLine(Convert.ToInt32(a1) + 1);
            //8809 100%
            //string a2 = Console.ReadLine();
            //string[] d = a2.Split(" ");
            //int resultd = Convert.ToInt32(d[0]) - Convert.ToInt32(d[1]);
            //Console.WriteLine(resultd);
            //8806 100%
            //string a3 = Console.ReadLine();
            //string[] d1 = a3.Split(" ");
            //int resultd1 = Convert.ToInt32(d1[0]) + Convert.ToInt32(d1[1]);
            //Console.WriteLine(resultd1);
            //8811 100%
            //string a4 = Console.ReadLine();
            //string[] d2 = a4.Split(" ");
            //int resultd2 = Convert.ToInt32(d2[0]) * Convert.ToInt32(d2[1]);
            //Console.WriteLine(resultd2);
            //8806 100%
            //string a4 = Console.ReadLine();
            //string[] d2 = a4.Split(" ");
            //int resultd2 = Convert.ToInt32(d2[0]) - Convert.ToInt32(d2[1]);
            //Console.WriteLine(resultd2);
            //
            string a = Console.ReadLine();
            string v = Console.ReadLine();
            string[] b = v.Split("");
            if (Convert.ToInt32(b[0]+b[1]+b[2]) == 3000) {
                Console.WriteLine("Error");
            }

        }
    }
}
