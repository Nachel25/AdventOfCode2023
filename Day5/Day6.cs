namespace Day6
{
    public class Day6
    {
        private readonly List<string> _inputAsList;

        private int _multipliedNumberOfSolutions;
        public int MultipliedNumberOfSolutions
        {
            get
            {
                CleanUpInput();

                

                return _multipliedNumberOfSolutions;
            }
        }

        private void CleanUpInput()
        {
            var time = _inputAsList[0].Substring(_inputAsList[0].IndexOf(':') + 1).Split(' ').Where(x => !string.IsNullOrEmpty(x)).ToList();
            var distance = _inputAsList[1].Substring(_inputAsList[1].IndexOf(':') + 1).Split(' ').Where(x => !string.IsNullOrEmpty(x)).ToList();
        }

        public Day6(string filepath)
        {
            _inputAsList = File.ReadAllLines(filepath).ToList();
        }
    }
}