namespace Day6
{
    public class Day6
    {
        private readonly List<string> _inputAsList;
        private List<int> _raceDurationsPart1;
        private List<int> _distanceRecordsPart1;
        private ulong _raceDurationsPart2;
        private ulong _distanceRecordsPart2;
        private List<int> _numberOfSolutionsPart1;

        private int _multipliedNumberOfSolutions;
        public int MultipliedNumberOfSolutions
        {
            get
            {
                CleanUpInput();

                for (int i = 0; i < _raceDurationsPart1.Count; i++)
                {
                    for (int buttonDuration = 0; buttonDuration < _raceDurationsPart1[i]; buttonDuration++)
                    {
                        var travelledDistance = (_raceDurationsPart1[i] - buttonDuration) * buttonDuration;

                        if (travelledDistance > _distanceRecordsPart1[i])
                        {
                            _numberOfSolutionsPart1[i]++;
                        }
                    }
                }

                _multipliedNumberOfSolutions = _numberOfSolutionsPart1.Aggregate(1, (x, y) => x * y); ;
                return _multipliedNumberOfSolutions;
            }
        }

        private long _correctedNumberOfSolutions;
        public long CorrectedNumberOfSolutions
        {
            get
            {
                CleanUpInputCorrected();

                for (ulong buttonDuration = 0; buttonDuration < _raceDurationsPart2; buttonDuration++)
                {
                    ulong travelledDistance = (_raceDurationsPart2 - buttonDuration) * buttonDuration;

                    if (travelledDistance > _distanceRecordsPart2)
                    {
                        _correctedNumberOfSolutions++;
                    }
                }

                return _correctedNumberOfSolutions;
            }
        }

        private void CleanUpInput()
        {
            _raceDurationsPart1 = _inputAsList[0].Substring(_inputAsList[0].IndexOf(':') + 1).Split(' ')
                .Where(x => !string.IsNullOrEmpty(x)).Select(int.Parse).ToArray().ToList();
            _distanceRecordsPart1 = _inputAsList[1].Substring(_inputAsList[1].IndexOf(':') + 1).Split(' ')
                .Where(x => !string.IsNullOrEmpty(x)).Select(int.Parse).ToArray().ToList();
        }

        private void CleanUpInputCorrected()
        {
            var raceDurationsString = _inputAsList[0].Substring(_inputAsList[0].IndexOf(':') + 1);
            _raceDurationsPart2 = Convert.ToUInt64(raceDurationsString.Replace(" ", ""));

            var distanceRecordsString = _inputAsList[1].Substring(_inputAsList[1].IndexOf(':') + 1);
            _distanceRecordsPart2 = Convert.ToUInt64(distanceRecordsString.Replace(" ", ""));
        }

        public Day6(string filepath)
        {
            _inputAsList = File.ReadAllLines(filepath).ToList();
            _raceDurationsPart1 = new List<int>();
            _distanceRecordsPart1 = new List<int>();
            _numberOfSolutionsPart1 = new List<int>(new int[4]);
        }
    }
}