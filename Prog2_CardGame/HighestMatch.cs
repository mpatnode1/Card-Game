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
        public int numberSwapped = 0;

        public HighestMatch() : base(1, new StandardDeck(RNG))
        {
            Rounds = RoundsHighestMatch;
        }

        public void Instructions()
        {
            Print("The");
            Print("Aces are low, and Jack, Queen, and King are high.");
        }

        public void Play()
        {
            int dealerHand = CalculateDealerHand();
            //display player hand
            //ask for input for hand

        }

        public void FinalHand()
        {
            //code to print final hand and compare with dealer
            //needs to take all of the components 
        }

        public void Setup()
        {
            DrawPile.Shuffle();
            for (int i = 0; i < PlayerHands.Count; i++)
            {
                var temp = PlayerHands[i];
                var draw = DrawPile.Draw(4);
                temp.AddRange(draw);
            }
            Print("");
            Print("This is your starting hand:");
            PrintHand();
            Print("");

            Print("Would you like to swap a card?");
            Print("Type a number 1 through 4 to swap.");

            char input;
            
            bool finishedInput = true;
            while (finishedInput == true)
            {
                input = ReadKey().KeyChar;
                Print("");
                switch (input)
                {
                    case '1':
                        numberSwapped = 1;
                        swapCards();
                        finishedInput = false;
                        break;
                    case '2':
                        numberSwapped = 2;
                        swapCards();
                        finishedInput = false;
                        break;
                    case '3':
                        numberSwapped = 3;
                        swapCards();
                        finishedInput = false;
                        break;
                    case '4':
                        numberSwapped = 4;
                        swapCards();
                        finishedInput = false;
                        break;
                    default:
                        Print("Please type in a number.");
                        finishedInput = true;
                        break;
                }
            }


        }

        void swapCards()
        {
            //removes card from hand and puts it to the back of drawpile
            Card cardGettingSwapped = PlayerHands[0].Cards[numberSwapped - 1];
            DrawPile.Add(cardGettingSwapped);
            PlayerHands[0].Cards.RemoveAt(numberSwapped -1);

            //draws card and inserts it into the spot that was removed
            var temp = PlayerHands[0];
            var draw = DrawPile.Draw(1);
            
            temp.InsertRange(numberSwapped - 1, draw);

            PrintHand();
        }

        public void PrintHand()
        {
            Print($"1. {PlayerHands[0].Cards[0]}");
            Print($"2. {PlayerHands[0].Cards[1]}");
            Print($"3. {PlayerHands[0].Cards[2]}");
            Print($"4. {PlayerHands[0].Cards[3]}");
        }

        public void PrintDealersHand()
        {
            Print($"1. {PlayerHands[1].Cards[0]}");
            Print($"2. {PlayerHands[1].Cards[1]}");
            Print($"3. {PlayerHands[1].Cards[2]}");
            Print($"4. {PlayerHands[1].Cards[3]}");
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
