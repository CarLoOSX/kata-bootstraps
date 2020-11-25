namespace Kata.Entities
{
    public class Frame
    {
        public int RollNumber { get; private set; }
        public int TotalRolls { get; }

        private int _pins;

        private readonly int _totalPins;

        public bool Strike { get; set; }

        public bool Spare { get; set; }

        public int[] Score { get; }

        public int Pins
        {
            get => _pins;
            set
            {
                _pins += value;

                Score[RollNumber] = value;

                if (_pins == _totalPins)
                {
                    if (RollNumber == 0)
                    {
                        Strike = true;
                        RollNumber = 1;
                        return;
                    }

                    Spare = true;
                }

                RollNumber++;
            }
        }

        public Frame()
        {
            _totalPins = 10;
            TotalRolls = 2;
            Score = new int[2];
        }
    }
}