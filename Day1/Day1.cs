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
                    var calibrationValueInRow = int.Parse(GetFirstDigits()[i].ToString() + GetLastDigits()[i].ToString());
                    _calibrationValueSum += calibrationValueInRow;
                }

                return _calibrationValueSum;
            }
        }

        private int _correctedCalibrationValueSum;
        public int CorrectedCalibrationValueSum
        {
            get
            {
                for (int i = 0; i < GetCorrectedFirstDigits().Count; i++)
                {
                    var calibrationValueInRow = int.Parse(GetCorrectedFirstDigits()[i].ToString() + GetCorrectedLastDigits()[i].ToString());
                    _correctedCalibrationValueSum += calibrationValueInRow;
                }

                return _correctedCalibrationValueSum;
            }
        }

        private List<char> GetFirstDigits()
        {
            var firstDigits = new List<char>();
            foreach (var row in _inputAsList)
            {
                var digitsInRow = row.SkipWhile(c => !char.IsDigit(c))
                    .TakeWhile(c => char.IsDigit(c));

                firstDigits.Add(digitsInRow.First());
            }
            return firstDigits;
        }

        private List<char> GetLastDigits()
        {
            var lastDigits = new List<char>();
            foreach (var row in _inputAsList)
            {
                var digitsInRow = row.Reverse()
                    .SkipWhile(c => !char.IsDigit(c))
                    .TakeWhile(c => char.IsDigit(c));

                lastDigits.Add(digitsInRow.First());
            }
            return lastDigits;
        }

        private List<char> GetCorrectedFirstDigits()
        {
            var firstDigits = new List<char>();
            foreach (var row in _inputAsList)
            {
                var correctedRow = ReplaceStringWithNumbers(row);
                var digitsInRow = correctedRow.SkipWhile(c => !char.IsDigit(c))
                    .TakeWhile(c => char.IsDigit(c));

                firstDigits.Add(digitsInRow.First());
            }
            return firstDigits;
        }

        private List<char> GetCorrectedLastDigits()
        {
            var lastDigits = new List<char>();
            foreach (var row in _inputAsList)
            {
                var correctedRow = ReplaceStringWithNumbers(row);
                var digitsInRow = correctedRow.Reverse()
                    .SkipWhile(c => !char.IsDigit(c))
                    .TakeWhile(c => char.IsDigit(c))
                    .ToArray();

                lastDigits.Add(digitsInRow.First());
            }
            return lastDigits;
        }

        private static string ReplaceStringWithNumbers(string row)
        {
            row = row.Replace("one", "one1one").Replace("two", "two2two").Replace("three", "three3three")
                .Replace("four", "four4four").Replace("five", "five5five").Replace("six", "six6six")
                .Replace("seven", "seven7seven").Replace("eight", "eight8eight").Replace("nine", "nine9nine");
            return row;
        }

        public Day1(string filepath)
        {
            _inputAsList = File.ReadAllLines(filepath).ToList();
        }
    }
}