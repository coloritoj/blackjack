using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class WagerHandler
    {
        public static double AskForPlayerWager()
        {
            Console.Write("How much would you like to wager?: $");

            double wagerAmount = double.Parse(Console.ReadLine());

            return wagerAmount;
        }
    }
}
