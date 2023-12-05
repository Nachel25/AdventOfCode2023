namespace Day3
{
    public class Day3
    {
        private const int DIMENSIONS = 10;
        private readonly char[,] _inputAs2dArray = new char[DIMENSIONS, DIMENSIONS];

        private int _sumOfPartNumbers;
        public int SumOfPartNumbers 
        { 
            get
            {
                var results = AdjacentElements(_inputAs2dArray, 1, 3);

                foreach (var result in results)
                    Console.WriteLine(result);
                return _sumOfPartNumbers;
            }
        }

        private IEnumerable<T> AdjacentElements<T>(T[,] arr, int row, int column)
        {
            int rows = arr.GetLength(0);
            int columns = arr.GetLength(1);

            for (int j = row - 1; j <= row + 1; j++)
                for (int i = column - 1; i <= column + 1; i++)
                    if (i >= 0 && j >= 0 && i < columns && j < rows && !(j == row && i == column))
                        yield return arr[j, i];
        }

        public Day3(string filepath)
        {
            StreamReader sr = File.OpenText(filepath);
            {
                for (int i = 0; i < DIMENSIONS; i++)
                {
                    string curLine = sr.ReadLine();
                    for (int j = 0; j < curLine.Length; j++)
                    {
                        _inputAs2dArray[i, j] = curLine[j];
                    }
                }
            }
        }
    }
}