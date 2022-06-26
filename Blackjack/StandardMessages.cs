using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class StandardMessages
    {
        public static bool ContinuePlaying()
        {
            Console.WriteLine("Would you like to play again? [Y]es/[N]o: ");

            string playerResponse = Console.ReadLine().ToLower();

            if (playerResponse == "yes" || playerResponse == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void RevealNumberOfCardsRemaining(List<Card> shoe)
        {
            Console.WriteLine($"{shoe.Count} cards remaining...");
        }

        public static string GetPlayerDecision(List<Card> playerHand)
        {
            int valueCardOne = playerHand[0].PrimaryValue;
            int valueCardTwo = playerHand[1].PrimaryValue;
            string answer;

            if (valueCardOne == valueCardTwo)
            {
                Console.Write("What would you like to do? [S]tand | [H]it | [D]ouble Down | [Sp]lit: ");
                answer = Console.ReadLine().ToLower();
            }
            else
            {
                Console.Write("What would you like to do? [S]tand | [H]it | [D]ouble Down: ");
                answer = Console.ReadLine().ToLower();
            }

            return answer;
        }
    }
}
