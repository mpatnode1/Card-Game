using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog2_CardGame
{
    public class Card
    {
        int deckSize = 52;
        public int Value;
        public string Suit;
        public string Rank;

        string[] Suits = { "Hearts", "Clubs", "Spades", "Diamonds" };
        string[] Ranks = {"Ace","2","3","4","5","6","7","8","9","10","Jack","Queen","King" };

        public Card()
        {



        }

        public void Start()
        {
            List<Card> Cards = new List<Card>();

            for (int i = 0; i < deckSize / Suits.Length; i++)
            {
                for (int j = 0; j < Suits.Length; j++)
                {
                        Cards.Add(new Card()
                        {
                            Value = i + 1,
                            Rank = Ranks[i],
                            Suit = Suits[j]

                        }
                        );
                        
                        Console.WriteLine($"{Ranks[i]} of {Suits[j]}");
                    }
                    



                
            }


        }
    }
}