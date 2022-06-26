namespace Blackjack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many decks would you like to add to the shoe?: ");
            int numberOfDecks = int.Parse(Console.ReadLine());
            List<Card> shoe = DeckGenerator.GenerateDeckOfCards(numberOfDecks);
            bool goAgain = false;
            bool isBlackjack = false;

            PlayerHand playerHand = new PlayerHand();
            DealerHand dealerHand = new DealerHand();

            do
            {
                Console.WriteLine();
                double playerWager = WagerHandler.AskForPlayerWager();

                playerHand.Cards = HandGenerator.DrawInitialHand(shoe);

                dealerHand.Cards = HandGenerator.DrawInitialHand(shoe);

                foreach (var card in playerHand.Cards)
                {
                    Console.WriteLine(card.Name);
                }

                isBlackjack = BlackjackChecker.CheckForPlayerBlackjack(playerHand.Cards);

                if (isBlackjack)
                {

                }
                else
                {
                    DecisionHandler.HandlePlayerDecision(playerHand, shoe);

                    foreach (var card in playerHand.Cards)
                    {
                        Console.WriteLine(card.Name);
                    }
                }                

                goAgain = StandardMessages.ContinuePlaying();

            } while (goAgain);

            Console.WriteLine("Thanks for playing!");

            Console.ReadLine();
        }
    }
}