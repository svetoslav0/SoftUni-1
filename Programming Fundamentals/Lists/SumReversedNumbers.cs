using System;
using System.Collections.Generic;
using System.Linq;
namespace Lists
{
    public class SumReversedNumbers
    {
        public static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                                        .Split()
                                        .Select(int.Parse)
                                        .ToList();
            int sum = 0;
            for (int i = 0; i < input.Count; i++)
            {
                int rev = 0;
                while (input[i] > 0)
                {
    
                    int r = input[i] % 10;
                    rev = rev * 10 + r;
                    input[i] = input[i] / 10;
                }
                sum += rev;
            }
            Console.WriteLine(sum);
        }
    }
}