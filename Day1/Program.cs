﻿using System;
using System.IO;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call Class Day1
            var day1 = new Day1(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\inputFiles\inputDay01.txt"));

            // Part 1
            Console.WriteLine("\nBeginning Day 1 Part 1");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"The sum of all calibration values is {day1.CalibrationValueSum}.");

            // Part 2
            //Console.WriteLine("\nBeginning Day 1 Part 2");
            //Console.WriteLine("----------------------------------------------------------------");
            //Console.WriteLine($"The best three elves are carrying {day1.LastDigit} calories.");
        }
    }
}