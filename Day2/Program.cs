using System;
using System.IO;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call Class Day2
            var day2 = new Day2(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\inputFiles\input.txt"));

            // Part 1
            Console.WriteLine("\nBeginning Day 2 Part 1");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"The sum of the game IDs is {day2.SumOfGameId}.");

            // Part 2
            //Console.WriteLine("\nBeginning Day 2 Part 2");
            //Console.WriteLine("----------------------------------------------------------------");
            //Console.WriteLine($"The corrected sum of all calibration values is {day2.CorrectedCalibrationValueSum}.");
        }
    }
}