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
                for (int i=0;i<2;i++)
                {
                    num[i] = Convert.ToDouble(ara[i]);
                }

                double len = Math.Sqrt(2)*num[1];
                len /= 2;
                //Console.Write("Case " + (j + 1) + ": ");

                //Console.WriteLine(Math.Abs(num[0]));
                //Console.WriteLine(Math.Abs(len));
                if (Math.Abs(len - num[0]) < .01)
                {
                    Console.WriteLine("Yes");
                }
                else Console.WriteLine("No");
            }

        }
    }
}
