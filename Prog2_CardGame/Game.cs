using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog2_CardGame
{
    public class CardGame
    {
        public int playerCount;
        private string gameRule;
        public List<CardPile> PlayerHands = new List<CardPile>();

        public static Random RNG = new Random();


        public CardGame(int playerCount) 
        {
            Deck deck = new Deck(RNG);
            deck.Shuffle();

            for (int i = 0; i < playerCount; i++) 
            {
                PlayerHands.Add(new CardPile(RNG));
            }

            /* Console.WriteLine(deck);
            Console.WriteLine("HAMBURGER");
            var temp = PlayerHands[0];
            var draw = deck.Draw(3);
            temp.AddRange(draw);
            Console.WriteLine("HAMBURGER");
            Console.WriteLine(PlayerHands[0]);
            Console.WriteLine("HAMBURGER");
            Console.WriteLine(deck); */
                
        }

        public void Start()
        {
            
        }

        private void listRules()
        {
            throw new System.NotImplementedException();
        }

        public void Turn()
        {
            throw new System.NotImplementedException();
        }

        public void MainMenu()
        {
            throw new System.NotImplementedException();
        }

        public void DeclareWinner()
        {
            throw new System.NotImplementedException();
        }
    }
}