namespace TemplateMethod
{
    public class CaliforniaFantasyFive : MagicLotteryNumberGenerator
    {
        public override string StatePopulation { get; set; }
        public override string AverageRainfall { get; set; }
        public override int NumberOfDigits { get; set; }

        public CaliforniaFantasyFive()
        {
            StatePopulation = "36961664";
            AverageRainfall = "17.18";
            NumberOfDigits = 5;
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
    }
}