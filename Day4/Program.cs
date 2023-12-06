namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call Class Day2
            var day4 = new Day4(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\inputFiles\input.txt"));

            // Part 1
            Console.WriteLine("\nBeginning Day 4 Part 1");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"The cards are worth {day4.PointsInTotal} points in total.");

            // Part 2
            Console.WriteLine("\nBeginning Day 4 Part 2");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"You end up with {day4.TotalNumberOfScratchCards} scratchcards.");
        }
    }
}