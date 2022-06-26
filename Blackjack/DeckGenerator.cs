using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class DeckGenerator
    {
        public static List<Card> GenerateDeckOfCards(int numberOfDecks)
        {
            List<Card> fullDeck = new List<Card>();

            for (int i = 0; i < numberOfDecks; i++)
            {
                List<Card> cards = new List<Card>
                {
                    new Card { Name = "ACE of SPADES", IsAce = true, PrimaryValue = 1, SecondaryValue = 11 },
                    new Card { Name = "ACE of HEARTS", IsAce = true, PrimaryValue = 1, SecondaryValue = 11 },
                    new Card { Name = "ACE of DIAMONDS", IsAce = true, PrimaryValue = 1, SecondaryValue = 11 },
                    new Card { Name = "ACE of CLUBS", IsAce = true, PrimaryValue = 1, SecondaryValue = 11 },

                    new Card { Name = "2 of SPADES", IsAce = false, PrimaryValue = 2, SecondaryValue = 0 },
                    new Card { Name = "2 of HEARTS", IsAce = false, PrimaryValue = 2, SecondaryValue = 0 },
                    new Card { Name = "2 of DIAMONDS", IsAce = false, PrimaryValue = 2, SecondaryValue = 0 },
                    new Card { Name = "2 of CLUBS", IsAce = false, PrimaryValue = 2, SecondaryValue = 0 },

                    new Card { Name = "3 of SPADES", IsAce = false, PrimaryValue = 3, SecondaryValue = 0 },
                    new Card { Name = "3 of HEARTS", IsAce = false, PrimaryValue = 3, SecondaryValue = 0 },
                    new Card { Name = "3 of DIAMONDS", IsAce = false, PrimaryValue = 3, SecondaryValue = 0 },
                    new Card { Name = "3 of CLUBS", IsAce = false, PrimaryValue = 3, SecondaryValue = 0 },

                    new Card { Name = "4 of SPADES", IsAce = false, PrimaryValue = 4, SecondaryValue = 0 },
                    new Card { Name = "4 of HEARTS", IsAce = false, PrimaryValue = 4, SecondaryValue = 0 },
                    new Card { Name = "4 of DIAMONDS", IsAce = false, PrimaryValue = 4, SecondaryValue = 0 },
                    new Card { Name = "4 of CLUBS", IsAce = false, PrimaryValue = 4, SecondaryValue = 0 },

                    new Card { Name = "5 of SPADES", IsAce = false, PrimaryValue = 5, SecondaryValue = 0 },
                    new Card { Name = "5 of HEARTS", IsAce = false, PrimaryValue = 5, SecondaryValue = 0 },
                    new Card { Name = "5 of DIAMONDS", IsAce = false, PrimaryValue = 5, SecondaryValue = 0 },
                    new Card { Name = "5 of CLUBS", IsAce = false, PrimaryValue = 5, SecondaryValue = 0 },

                    new Card { Name = "6 of SPADES", IsAce = false, PrimaryValue = 6, SecondaryValue = 0 },
                    new Card { Name = "6 of HEARTS", IsAce = false, PrimaryValue = 6, SecondaryValue = 0 },
                    new Card { Name = "6 of DIAMONDS", IsAce = false, PrimaryValue = 6, SecondaryValue = 0 },
                    new Card { Name = "6 of CLUBS", IsAce = false, PrimaryValue = 6, SecondaryValue = 0 },

                    new Card { Name = "7 of SPADES", IsAce = false, PrimaryValue = 7, SecondaryValue = 0 },
                    new Card { Name = "7 of HEARTS", IsAce = false, PrimaryValue = 7, SecondaryValue = 0 },
                    new Card { Name = "7 of DIAMONDS", IsAce = false, PrimaryValue = 7, SecondaryValue = 0 },
                    new Card { Name = "7 of CLUBS", IsAce = false, PrimaryValue = 7, SecondaryValue = 0 },

                    new Card { Name = "8 of SPADES", IsAce = false, PrimaryValue = 8, SecondaryValue = 0 },
                    new Card { Name = "8 of HEARTS", IsAce = false, PrimaryValue = 8, SecondaryValue = 0 },
                    new Card { Name = "8 of DIAMONDS", IsAce = false, PrimaryValue = 8, SecondaryValue = 0 },
                    new Card { Name = "8 of CLUBS", IsAce = false, PrimaryValue = 8, SecondaryValue = 0 },

                    new Card { Name = "9 of SPADES", IsAce = false, PrimaryValue = 9, SecondaryValue = 0 },
                    new Card { Name = "9 of HEARTS", IsAce = false, PrimaryValue = 9, SecondaryValue = 0 },
                    new Card { Name = "9 of DIAMONDS", IsAce = false, PrimaryValue = 9, SecondaryValue = 0 },
                    new Card { Name = "9 of CLUBS", IsAce = false, PrimaryValue = 9, SecondaryValue = 0 },

                    new Card { Name = "10 of SPADES", IsAce = false, PrimaryValue = 10, SecondaryValue = 0 },
                    new Card { Name = "10 of HEARTS", IsAce = false, PrimaryValue = 10, SecondaryValue = 0 },
                    new Card { Name = "10 of DIAMONDS", IsAce = false, PrimaryValue = 10, SecondaryValue = 0 },
                    new Card { Name = "10 of CLUBS", IsAce = false, PrimaryValue = 10, SecondaryValue = 0 },

                    new Card { Name = "JACK of SPADES", IsAce = false, PrimaryValue = 10, SecondaryValue = 0 },
                    new Card { Name = "JACK of HEARTS", IsAce = false, PrimaryValue = 10, SecondaryValue = 0 },
                    new Card { Name = "JACK of DIAMONDS", IsAce = false, PrimaryValue = 10, SecondaryValue = 0 },
                    new Card { Name = "JACK of CLUBS", IsAce = false, PrimaryValue = 10, SecondaryValue = 0 },

                    new Card { Name = "QUEEN of SPADES", IsAce = false, PrimaryValue = 10, SecondaryValue = 0 },
                    new Card { Name = "QUEEN of HEARTS", IsAce = false, PrimaryValue = 10, SecondaryValue = 0 },
                    new Card { Name = "QUEEN of DIAMONDS", IsAce = false, PrimaryValue = 10, SecondaryValue = 0 },
                    new Card { Name = "QUEEN of CLUBS", IsAce = false, PrimaryValue = 10, SecondaryValue = 0 },

                    new Card { Name = "KING of SPADES", IsAce = false, PrimaryValue = 10, SecondaryValue = 0 },
                    new Card { Name = "KING of HEARTS", IsAce = false, PrimaryValue = 10, SecondaryValue = 0 },
                    new Card { Name = "KING of DIAMONDS", IsAce = false, PrimaryValue = 10, SecondaryValue = 0 },
                    new Card { Name = "KING of CLUBS", IsAce = false, PrimaryValue = 10, SecondaryValue = 0 },
                };

                foreach (var card in cards)
                {
                    fullDeck.Add(card);
                }
            }            

            return fullDeck;
        }
    }
}
