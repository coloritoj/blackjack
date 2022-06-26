using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Card
    {
        public string Name { get; set; }

        public int PrimaryValue { get; set; }

        public int SecondaryValue { get; set; } = 0;

        public bool IsAce { get; set; } = false;

    }
}
