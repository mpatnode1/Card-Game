using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Prog2_CardGame.Utility;
using static System.Console;

namespace Prog2_CardGame
{
    internal class HighestMatch : CardGame, IPlay
    {
        int RoundsHighestMatch = 10;
        public HighestMatch() : base(1, new StandardDeck(RNG))
        {
            Rounds = RoundsHighestMatch;
        }

        public void Instructions()
        {
            Print(" ");
            Print("Aces are low, and Jack, Queen, and King are high.");
        }

        public void Play()
        {

        }

        public void FinalHand()
        {
            //code to print final hand and compare with dealer
            //needs to take all of the components 
        }

        public void Setup()
        {
            //dealer is going to be handed 4 cards that will remain the same for the entire game
            //four cards will be dealt to the player
        }

        public int CalculateDealerHand()
        {
            //math for dealer hand can be done here
            //then in final hand number can be compared with number from finalhand
            //should return single number that is the highest from its hand
            return 0;
        }
    }
}
