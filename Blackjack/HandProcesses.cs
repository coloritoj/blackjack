using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class HandProcesses
    {
        public static int GetTotalCardValue(List<Card> hand)
        {
            int sum = hand.Sum(card => card.PrimaryValue);

            return sum;
        }

        public static bool IsHandValueAt21(List<Card> hand)
        {
            int sum = hand.Sum(card => card.PrimaryValue);

            if (sum == 21)
            {
                return true;
            }

            return false;
        }

        public static bool IsHandValueGreaterThan21(List<Card> hand)
        {
            int sum = hand.Sum(card => card.PrimaryValue);

            if (sum > 21)
            {
                return true;
            }

            return false;
        }

        public static Card DoubleDown(List<Card> shoe)
        {
            Random random = new Random();

            Card cardToReturn = shoe[random.Next(shoe.Count)];

            shoe.Remove(cardToReturn);

            return cardToReturn;
        }

        public static Card DrawCard(List<Card> shoe)
        {
            Random random = new Random();

            Card cardToReturn = shoe[random.Next(shoe.Count)];

            shoe.Remove(cardToReturn);

            return cardToReturn;
        }

        public static List<Card> HitProcess(List<Card> playerHand, List<Card> shoe)
        {
            string hitAgain = "";

            do
            {
                playerHand.Add(DrawCard(shoe));

                Console.WriteLine($"You drew a {playerHand[playerHand.Count() - 1].Name}. Your hand value is now {playerHand.Sum(card => card.PrimaryValue)}.");

                if (IsHandValueGreaterThan21(playerHand))
                {
                    Console.WriteLine("You busted...");
                    return playerHand;
                }

                if (IsHandValueAt21(playerHand))
                {                    
                    Console.WriteLine("Automatically standing...");
                    return playerHand;
                }

                Console.Write("Would you like to hit again? [Y]es/[N]o: ");
                hitAgain = Console.ReadLine().ToLower();

            } while (hitAgain == "yes" || hitAgain == "y");

            return playerHand;
        }

        public static List<Card> DealerHitProcess(List<Card> dealerHand, List<Card> shoe)
        {
            int dealerHandValue = dealerHand.Sum(card => card.PrimaryValue);

            do
            {
                dealerHand.Add(DrawCard(shoe));

                Console.WriteLine($"The dealer drew a {dealerHand[dealerHand.Count() - 1].Name}. The dealer's hand value is now {dealerHand.Sum(card => card.PrimaryValue)}.");

                if (IsHandValueGreaterThan21(dealerHand))
                {
                    Console.WriteLine("The dealer busted...");
                    return dealerHand;
                }

                if (IsHandValueAt21(dealerHand))
                {
                    Console.WriteLine("The dealer is automatically standing...");
                    return dealerHand;
                }

            } while (dealerHandValue < 16);

            return dealerHand;
        }

    }
}
