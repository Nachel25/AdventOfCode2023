namespace Day4
{
    public class Day4
    {
        private readonly List<string> _inputAsList;
        private List<int[]> _listOfWinningNumbers;
        private List<int[]> _listOfOwnNumbers;
        private List<int> _listOfCopies;

        private int _pointsInTotal;
        public int PointsInTotal
        {
            get
            {
                CleanUpInput();

                for (int i = 0; i < _listOfOwnNumbers.Count; i++)
                {
                    var intersectingElements = _listOfOwnNumbers[i].Intersect(_listOfWinningNumbers[i]).ToArray().Length;

                    if (intersectingElements == 1)
                    {
                        _pointsInTotal++;
                    }
                    else if (intersectingElements > 1)
                    {
                        _pointsInTotal += (int)Math.Pow(2, intersectingElements - 1);
                    }
                }

                return _pointsInTotal;
            }
        }

        private int _totalNumberOfScratchCards;
        public int TotalNumberOfScratchCards
        {
            get
            {
                CleanUpInput();
                for (int i = 0; i < _listOfCopies.Count; i++)
                {
                    _listOfCopies[i] = 1;
                }

                for (int i = 0; i < _listOfOwnNumbers.Count; i++)
                {
                    var intersectingElements = _listOfOwnNumbers[i].Intersect(_listOfWinningNumbers[i]).ToArray().Length;

                    for (int j = i; j < i + intersectingElements; j++)
                    {
                        _listOfCopies[j + 1] += _listOfCopies[i];
                    }
                }
                _totalNumberOfScratchCards = _listOfCopies.Sum();
                return _totalNumberOfScratchCards;
            }
        }

        private void CleanUpInput()
        {
            var scratchCards = _inputAsList.Select(x => x.Remove(0, 10)).ToList();
            var winningAndOWnNumbers = scratchCards.Select(x => x.Split(" | ")).ToList();
            _listOfWinningNumbers = winningAndOWnNumbers.Select(x => x[0].Split(' ').Where(x => !string.IsNullOrEmpty(x)).Select(int.Parse).ToArray()).ToList();
            _listOfOwnNumbers = winningAndOWnNumbers.Select(x => x[1].Split(' ').Where(x => !string.IsNullOrEmpty(x)).Select(int.Parse).ToArray()).ToList();
        }

        public Day4(string filepath)
        {
            _inputAsList = File.ReadAllLines(filepath).ToList();
            _listOfWinningNumbers = new List<int[]>();
            _listOfOwnNumbers = new List<int[]>();
            _listOfCopies = new List<int>(new int[212]);
        }
    }
}