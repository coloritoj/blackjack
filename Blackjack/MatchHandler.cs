using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class MatchHandler
    {
        public static MatchHandlerObject ProcessMatch(PlayerHand playerHand, DealerHand dealerHand, List<Card> shoe)
        {
            MatchHandlerObject matchHandlerObject = new MatchHandlerObject();

            DecisionHandler.HandlePlayerDecision(playerHand, shoe);

            int sumOfPlayerCards = playerHand.Cards.Sum(card => card.PrimaryValue);

            DecisionHandler.HandleDealerDecision(dealerHand, shoe);

            int sumOfDealersCards = dealerHand.Cards.Sum(card => card.PrimaryValue);  

            if (CheckForPlayerWinViaDealerBust(sumOfPlayerCards, sumOfDealersCards))
            {
                matchHandlerObject.PlayerWinViaDealerBust = true;
                return matchHandlerObject;
            }

            if (CheckForPlayerWinViaHigherScoreThanDealer(sumOfPlayerCards, sumOfDealersCards))
            {
                matchHandlerObject.PlayerWinViaHigherScoreThanDealer = true;
                return matchHandlerObject;
            }

            if (CheckForTieBetweenPlayerAndDealer(sumOfPlayerCards, sumOfDealersCards))
            {
                matchHandlerObject.TieBetweenPlayerAndDealer = true;
                return matchHandlerObject;
            }

            if (CheckForPlayerLossViaPlayerBust(sumOfPlayerCards, sumOfDealersCards))
            {
                matchHandlerObject.PlayerLossViaPlayerBust = true;
                return matchHandlerObject;
            }

            if (CheckForPlayerLossViaLowerScoreThanDealer(sumOfPlayerCards, sumOfDealersCards))
            {
                matchHandlerObject.PlayerLossViaLowerScoreThanDealer = true;
                return matchHandlerObject;
            }
        }

        public static bool CheckForPlayerWinViaDealerBust(int sumOfPlayersCards, int sumOfDealersCards)
        {
            if (sumOfPlayersCards <= 21 && sumOfDealersCards > 21)
            {
                return true;
            }

            return false;
        }

        public static bool CheckForPlayerWinViaHigherScoreThanDealer(int sumOfPlayersCards, int sumOfDealersCards)
        {
            if (sumOfPlayersCards <= 21 && (sumOfPlayersCards > sumOfDealersCards))
            {
                return true;
            }

            return false;
        }

        public static bool CheckForTieBetweenPlayerAndDealer(int sumOfPlayersCards, int sumOfDealersCards)
        {
            if (sumOfDealersCards <= 21 && (sumOfPlayersCards == sumOfDealersCards))
            {
                return true;
            }

            return false;
        }

        public static bool CheckForPlayerLossViaPlayerBust(int sumOfPlayersCards, int sumOfDealersCards)
        {
            if (sumOfPlayersCards > 21)
            {
                return true;
            }
            return false;
        }

        public static bool CheckForPlayerLossViaLowerScoreThanDealer(int sumOfPlayersCards, int sumOfDealersCards)
        {
            if (sumOfPlayersCards <=21 && sumOfDealersCards <=21 && (sumOfPlayersCards < sumOfDealersCards))
            {
                return true;
            }
            return false;
        }
    }
}
