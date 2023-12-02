namespace Day1
{
    public class Day1
    {
        private readonly List<string> _inputAsList;

        private int _calibrationValueSum;
        public int CalibrationValueSum
        {
            get
            {
                for (int i = 0; i < GetFirstDigits().Count; i++)
                {
                    var calibrationValueSumInRow = int.Parse(GetFirstDigits()[i].ToString() + GetLastDigits()[i].ToString());
                    _calibrationValueSum += calibrationValueSumInRow;
                }
                
                return _calibrationValueSum;
            }
        }

        private List<char> GetLastDigits()
        {
            var lastDigits = new List<char>();
            foreach (var row in _inputAsList)
            {
                var digitsInRow = row.Reverse()
                    .SkipWhile(c => !char.IsDigit(c))
                    .TakeWhile(c => char.IsDigit(c))
                    .ToArray();

                lastDigits.Add(digitsInRow.First());
            }
            return lastDigits;
        }

        private List<char> GetFirstDigits()
        {
            var firstDigits = new List<char>();
            foreach (var row in _inputAsList)
            {
                var digitsInRow = row.SkipWhile(c => !char.IsDigit(c))
                    .TakeWhile(c => char.IsDigit(c))
                    .ToArray();

                firstDigits.Add(digitsInRow.First());
            }
            return firstDigits;
        }

        public Day1(string filepath)
        {
            _inputAsList = File.ReadAllLines(filepath).ToList();
        }
    }
}