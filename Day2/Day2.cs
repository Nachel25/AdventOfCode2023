namespace Day2
{
    public class Day2
    {
        private readonly List<string> _inputAsList;
        private List<string> _gameId;

        private int _sumOfGameId;
        public int SumOfGameId
        {
            get
            {
                CleanUpInput();
                foreach (var row in _inputAsList)
                {
                    _gameId = row.Split(':', ';').ToList();
                }
                return _sumOfGameId;
            }
        }

        private void CleanUpInput()
        {
            var games = _inputAsList.Select(x => x.Remove(0, 8)).ToList();
        }

        public Day2(string filepath)
        {
            _inputAsList = File.ReadAllLines(filepath).ToList();
            _gameId = new List<string>();
        }
    }
}