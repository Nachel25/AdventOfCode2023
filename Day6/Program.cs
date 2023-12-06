namespace Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call Class Day2
            var day6 = new Day6(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\inputFiles\input.txt"));

            // Part 1
            Console.WriteLine("\nBeginning Day 6 Part 1");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"The value of the multiplied number of solutions is {day6.MultipliedNumberOfSolutions}.");

            // Part 2
            Console.WriteLine("\nBeginning Day 6 Part 2");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"The corrected value of the multiplied number of solutions is {day6.CorrectedNumberOfSolutions}.");
        }
    }
}