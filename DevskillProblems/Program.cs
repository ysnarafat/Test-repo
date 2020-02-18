using System;

namespace DevskillProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            int t;
            t = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < t; j++)
            {
                string s = Console.ReadLine();
                string[] ara = s.Split(' ');
                double[] num = new double[20];
                for (int i=0;i<5;i++)
                {
                    num[i] = Convert.ToDouble(ara[i]);

                    //Console.WriteLine(ara[i] + " " + num[i]);
                    //i++;
                }

                double len = Math.Sqrt((num[0] - num[3])* (num[0] - num[3]) + (num[1] - num[4])* (num[1] - num[4]));
                Console.Write("Case " + (j + 1) + ": ");
                if (len < num[2])
                {
                    Console.WriteLine("Inside");
                }
                else if (len > num[2]) Console.WriteLine("Outside");
                else Console.WriteLine("OnCircle");
            }

        }
    }
}
