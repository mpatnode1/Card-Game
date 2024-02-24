using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Prog2_CardGame
{
    public class StandardDeck : CardPile
    {
        int deckSize = 52;
        string[] Suits = { "Hearts", "Clubs", "Spades", "Diamonds" };

        public StandardDeck(Random RNG) : base(RNG) //might need to take in suitAmount from game
        {
            // if statement that takes in int suitAmount = 2 then
            // change decksize to 26

            for (int i = 0; i < deckSize / Suits.Length; i++)
            {
                for (int j = 0; j < Suits.Length; j++)
                {
                    Cards.Add(new Card(i + 1, Suits[j]));
                }
            }

        }
      
    }
}
