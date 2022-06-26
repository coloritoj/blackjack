using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class MatchHandlerObject
    {
        public bool PlayerWinViaDealerBust { get; set; } = false;

        public bool PlayerWinViaHigherScoreThanDealer { get; set; } = false;

        public bool TieBetweenPlayerAndDealer { get; set; } = false;

        public bool PlayerLossViaPlayerBust { get; set; } = false;

        public bool PlayerLossViaLowerScoreThanDealer { get; set; } = false;
    }
}
