namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call Class Day2
            var day3 = new Day3(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\inputFiles\example.txt"));

            // Part 1
            Console.WriteLine("\nBeginning Day 3 Part 1");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"The sum of the part numbers is {day3.SumOfPartNumbers}.");

            // Part 2
            //Console.WriteLine("\nBeginning Day 3 Part 2");
            //Console.WriteLine("----------------------------------------------------------------");
            //Console.WriteLine($"The corrected sum of all calibration values is {day2.CorrectedCalibrationValueSum}.");
        }
    }
}