using System;

namespace TemplateMethod
{
    public class TemplateMethodClient
    {
        private static void Main(string[] args)
        {
            var program = new TemplateMethodClient();
            program.BuyLotteryTickets();

            Console.WriteLine("Buy the ticket and retire!");
            Console.ReadLine();
        }

        private void BuyLotteryTickets()
        {
            // Upcast instantiated derived class to base
            // Example of Listov Substitution Design Principle
            MagicLotteryNumberGenerator magicLotteryNumberGenerator 
                = new LottoTexas();
            var lottoTexasNumber = magicLotteryNumberGenerator.Generate();
            Console.WriteLine("Winning number for Lotto Texas: {0}", lottoTexasNumber);

            // Upcast derived class to base
            magicLotteryNumberGenerator = new CaliforniaFantasyFive();
            var fantasyFiveNumber = magicLotteryNumberGenerator.Generate();
            Console.WriteLine("Winning number for CA Fantasy Fives: {0}", fantasyFiveNumber);
        }
    }
}