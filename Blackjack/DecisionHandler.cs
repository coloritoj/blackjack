using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class DecisionHandler
    {
        public static void HandlePlayerDecision(PlayerHand playerHand, List<Card> shoe)
        {
            Console.WriteLine();
            string decision = StandardMessages.GetPlayerDecision(playerHand.Cards);

            if (decision == "s")
            {
                Console.WriteLine();
                Console.WriteLine($"You decided to stand. Your hand value remains at {playerHand.Cards.Sum(card => card.PrimaryValue)}.");
            }

            if (decision == "h")
            {
                Console.WriteLine();
                playerHand.Cards = HandProcesses.HitProcess(playerHand.Cards, shoe);
            }

            if (decision == "d")
            {
                Console.WriteLine();
                playerHand.Cards.Add(HandProcesses.DoubleDown(shoe));

                Console.WriteLine($"Your hand value is {HandProcesses.GetTotalCardValue(playerHand.Cards)}");
            }
        }

        public static void HandleDealerDecision(DealerHand dealerHand, List<Card> shoe)
        {

        }
    }
}
