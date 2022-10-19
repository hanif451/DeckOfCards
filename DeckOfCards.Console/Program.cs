using DeckOfCard.BusinessLayer;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Deck Of Cards!-----------");
            PokerCard pc = new PokerCard();
            pc.Shuffle();

            var response = pc.DealOneCard();
            Console.WriteLine($"First Card Picked is: --{response.CardPicked}--");
            int index = 2;
            while (response.RemainingCards.Length > 0)
            {
             //   Console.WriteLine($"The {response.CardPicked} Card is ABOUT TO BE Picked on attempt No {response.PickedUpCards.Length+1}");

              response = pc.DealOneCard();
                Console.WriteLine($"The --{response.CardPicked} -- Card is Picked on attempt No {index}"  );
                index++;
            }

            // Card picked 53rd time
            response = pc.DealOneCard();
            string valueOf53rdAttempt = response.CardPicked == null ? "NO" : response.CardPicked;
            Console.WriteLine($"The {valueOf53rdAttempt} Card is Picked on attempt No  53");

        }
    }
}
