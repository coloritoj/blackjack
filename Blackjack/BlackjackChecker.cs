namespace Blackjack
{
    public class BlackjackChecker
    {
        public static bool CheckForPlayerBlackjack(List<Card> playerHand)
        {
            if (playerHand[0].IsAce && playerHand[1].PrimaryValue == 10)
            {
                return true;
            }

            if (playerHand[1].PrimaryValue == 10 && playerHand[0].IsAce)
            {
                return true;
            }

            return false;
        }

        public static bool CheckForDealerUpcardAce(List<Card> dealerHand)
        {
            if (dealerHand[0].IsAce)
            {
                return true;
            }

            return false;
        }

        public static bool CheckForDealerUpcardAceBlackjack(List<Card> dealerHand)
        {
            if (dealerHand[0].IsAce && dealerHand[1].PrimaryValue == 10)
            {
                return true;
            }

            return false;
        }

        public static bool CheckForDealerBackdoorBlackjack(List<Card> dealerHand)
        {
            if (dealerHand[0].PrimaryValue == 10 && dealerHand[1].IsAce == true)
            {
                return true;
            }

            return false;
        }

        public static bool CheckForTieOnBackdoorBlackjack(List<Card> playerHand, List<Card> dealerHand)
        {
            bool playerHasBlackjack = CheckForPlayerBlackjack(playerHand);

            bool dealerHasBackdoorBlackjack = CheckForDealerBackdoorBlackjack(dealerHand);

            if (playerHasBlackjack && dealerHasBackdoorBlackjack)
            {
                return true;
            }

            return false;
        }

        public static double GetInsuranceAmount(List<Card> dealerHand, double wagerAmount)
        {
            double insuranceAmount = 0;

            if (dealerHand[0].IsAce)
            {
                bool isInsuranceAccepted = OfferInsurance(wagerAmount);

                if (isInsuranceAccepted)
                {
                    insuranceAmount = (wagerAmount / 2);
                }
            }

            return insuranceAmount;
        }

        public static bool OfferInsurance(double wagerAmount)
        {
            Console.Write($"The dealer's upcard is an Ace. Would you like to purchase insurance for ${wagerAmount / 2}? [Y]es/[N]o: ");

            string response = Console.ReadLine().ToLower();

            if (response == "y" || response == "yes")
            {
                Console.WriteLine($"Insurance amount of ${wagerAmount / 2} was accepted.");
                return true;
            }

            return false;
        }


        //public static double BlackjackCheckerFullProcess(PlayerHand playerHand, DealerHand dealerHand, List<Card> shoe, double wagerAmount)
        //{
        //    double amountToReturn = 0;

        //    if (CheckForDealerBackdoorBlackjack(dealerHand.Cards))
        //    {
        //        Console.WriteLine("The dealer also has a Blackjack. You push!");
        //        amountToReturn = wagerAmount;
        //        return amountToReturn;
        //    }

        //    if (CheckForDealerUpcardAce(dealerHand.Cards))
        //    {
        //        double playerInsuranceAmount = GetInsuranceAmount(dealerHand.Cards, wagerAmount);

        //        if (CheckForDealerUpcardAceBlackjack(dealerHand.Cards))
        //        {
        //            Console.WriteLine("The dealer has a Blackjack. You push!");
        //            amountToReturn += wagerAmount + playerInsuranceAmount;
        //            return amountToReturn;
        //        }

        //        if (playerInsuranceAmount == 0)
        //        {
        //            Console.WriteLine("The dealer does not have a Blackjack.");
        //        }
                
        //        if (playerInsuranceAmount > 0)
        //        {
        //            Console.WriteLine($"The dealer does not have a Blackjack. Your insurance wager of ${playerInsuranceAmount} is forfeited.");
        //        }
        //    }



        //}
    }
}
