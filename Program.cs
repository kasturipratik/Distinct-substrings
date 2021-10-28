using System;
using System.Collections.Generic;

namespace Distinct_substrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = divisorSubstrings(5341, 2);
            var test2 = divisorSubstrings(120, 2);
            var test3 = divisorSubstrings(555, 1);
            print(test);
            print(test3);
            print(test2);
        }
        static void print(int a)
        {
            Console.WriteLine(a);
        }

        static int divisorSubstrings(int n, int k)
        {
            string x = n.ToString();

            int count = 0;
            List<string> listOfNewText = new List<string>();

            for (int i = 0; i < x.Length - 1; i++)
            {
                var newText = x.Substring(i, k);
                if (newText.Length == k)
                {
                    var num = Convert.ToInt32(newText);
                    if (num != 0 && n % num == 0 && !listOfNewText.Contains(newText))
                    {
                        listOfNewText.Add(newText);
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
