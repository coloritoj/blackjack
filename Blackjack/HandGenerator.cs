using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class HandGenerator
    {
        public static List<Card> DrawInitialHand(List<Card> shoe)
        {
            List<Card> handToReturn = new List<Card>();

            Random random = new Random();

            int randomIndex = random.Next(0, shoe.Count);

            Card firstCard = shoe[randomIndex];

            handToReturn.Add(firstCard);

            shoe.Remove(firstCard);

            randomIndex = random.Next(0, shoe.Count);

            Card secondCard = shoe[randomIndex];

            handToReturn.Add(secondCard);

            shoe.Remove(secondCard);

            return handToReturn;
        }

        public static Card DrawCard(List<Card> shoe)
        {
            Random random = new Random();

            Card cardToReturn = shoe[random.Next(shoe.Count)];

            shoe.Remove(cardToReturn);

            return cardToReturn;
        }
    }
}
