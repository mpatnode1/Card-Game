using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Prog2_CardGame
{
    public class Deck
    {
        int deckSize = 52;
        string[] Suits = { "Hearts", "Clubs", "Spades", "Diamonds" };
        Random RNG;
        List<Card> Cards;

        public Deck(Random RNG)
        {
            this.RNG = RNG;

            this.Cards = new List<Card>();

            for (int i = 0; i < deckSize / Suits.Length; i++)
            {
                for (int j = 0; j < Suits.Length; j++)
                {
                    Cards.Add(new Card(i + 1, Suits[j]));
                }
            }

        }

        public void Shuffle()
        {

            int n = Cards.Count;
            while (n > 1)
            {
                int k = RNG.Next(n--);
                Card temp = Cards[n];
                Cards[n] = Cards[k];
                Cards[k] = temp;
            }
            
        }

        public void Deal(int PlayerCount)
        {
            //take cards list
            //foreach playerCount add int startingHand to each playerhand
            //remove each card added to a player hand from cards list
           
        }

        public void Draw()
        { 
            //take remaining cards list
            //when player draws
            //remove card from deck, add to playerhand,
            //read to player what card they drew ex: king of hearts in console
        }
    }
}
