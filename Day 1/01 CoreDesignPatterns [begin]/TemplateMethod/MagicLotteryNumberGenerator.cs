namespace TemplateMethod
{
    public abstract class MagicLotteryNumberGenerator
    {
        private const string AverageDepthOfLakeErie = "62";
        private const string NumberOfMoonsForSaturn = "60";
        public abstract string StatePopulation { get; set; }
        public abstract string AverageRainfall { get; set; }
        public abstract int NumberOfDigits { get; set; }
        
        // This is the Template Method
        // Series of steps implemented as method in both base and child classes
        public string Generate()
        {
            var firstDigit = PickDigit1();
            var secondDigit = PickDigit2();
            var thirdDigit = PickDigit3();
            var fourthDigit = PickDigit4();
            var fifthDigit = PickDigit5();
            var lastDigitsSet = PickLastDigits();

            return firstDigit + secondDigit + thirdDigit + fourthDigit + fifthDigit + lastDigitsSet;
        }

        // Client must implement this algorithm step
        protected abstract string PickDigit1();

        // Same implementation for all clients
        protected string PickDigit2()
        {
            // Substring number, extracting first digit
            return NumberOfMoonsForSaturn.Substring(1, 1);
        }

        // Client must implement this algorithm step
        protected abstract string PickDigit3();

        // Client must implement this algorithm step
        protected abstract string PickDigit4();

        // Base implements this algorithm step
        protected string PickDigit5()
        {
            // Substring number, extracting second digit
            return AverageDepthOfLakeErie.Substring(1, 1);
        }

        // Hook method. Can override if necessary to support lottery
        // number for which more than 5 characters exist
        protected virtual string PickLastDigits()
        {
            return string.Empty;
        }
    }
}