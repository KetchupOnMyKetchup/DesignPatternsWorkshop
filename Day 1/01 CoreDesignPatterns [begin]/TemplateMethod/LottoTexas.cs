using System;

namespace TemplateMethod
{
    public class LottoTexas : MagicLotteryNumberGenerator
    {
        public override string StatePopulation { get; set; }
        public override string AverageRainfall { get; set; }
        public override int NumberOfDigits  { get; set; }

        public LottoTexas()
        {
            StatePopulation = "24780000";
            AverageRainfall = "33.22";
            NumberOfDigits = 6;
        }

        protected override string PickDigit1()
        {
            // First two digits of average rainfall for state capital
            return AverageRainfall.Substring(3, 1);
        }

        protected override string PickDigit3()
        {
            // Second digit for state population
            return StatePopulation.Substring(1, 1);
        }

        protected override string PickDigit4()
        {
            // Fifth digit for state population
            return StatePopulation.Substring(5, 1);
        }

        protected override string PickLastDigits()
        {
            return new Random().Next(NumberOfDigits - 5).ToString();
        }
    }
}