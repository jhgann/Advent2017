using System;
using System.Linq;

namespace advent2017_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText("input.txt");

            int[] numbers = text.Select(c => int.Parse(c.ToString())).ToArray();
            var halfValue = numbers.Count()/2;
            
            Console.WriteLine("final numbers:");
            int[] finalNumbers = numbers.Take(numbers.Count()).ToArray();
            finalNumbers = finalNumbers.Concat(numbers.Take(halfValue)).ToArray();
            foreach (var item in finalNumbers) {
                Console.Write(item);
            }
            Console.WriteLine();
            
            Console.WriteLine("result:");
            int sum = 0;
            var length = finalNumbers.Count()-halfValue;
            for (int i = 0; i < length; i++) {
                if (finalNumbers[i] == finalNumbers[i+halfValue]) {
                    sum += finalNumbers[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
