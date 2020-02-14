using System;
using System.Collections.Generic;

namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> num = new List<string>;
            List<KeyValuePair> dic = new List<KeyValuePair>;
            int t = Convert.ToInt32(Console.ReadLine());
            for(int k = 0; k < t; k++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                string s;
                for (int i = 0; i < n; i++)
                {
                    s = Console.ReadLine();
                    num.Add(s);
                }
                for (int i = 0; i < n; i++)
                {
                    s = Console.ReadLine();
                    string[] str = s.Split(',');
                    
                }

            }
        }
    }
}
