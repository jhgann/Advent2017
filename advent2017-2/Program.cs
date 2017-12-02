using System;
using System.Linq;
using System.Collections.Generic;

namespace advent2017_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var splitLines = System.IO.File.ReadLines("input.txt").Select(line => line.Split('\t'));
            var numberLists = splitLines.Select(line => 
                line.Select(item => 
                    int.Parse(item)).ToList()).ToList();

            var checksum = 0;
            checksum = numberLists.Sum(nums => FindDivisibleValue(nums));

            Console.WriteLine(checksum);
        }

        static int FindDivisibleValue(List<int> nums) {
            int divisible = 0;
            nums = nums.OrderByDescending(x => x).ToList();
            nums.ForEach(x => {
                //probably a cleaner way to do this.
                int? z = nums.FirstOrDefault(y => x!=y && x%y == 0);
                if (z != null && z.Value != 0) {
                    divisible = x/z.Value;
                }
            });
            return divisible;

        }
    }
}
