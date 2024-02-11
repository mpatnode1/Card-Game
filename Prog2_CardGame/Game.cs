using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog2_CardGame
{
    public class CardGame
    {
        public int playerCount = 4;
        private string gameRule;

        public static Random RNG = new Random();

        public CardGame() 
        {
            Deck deck = new Deck(RNG);
            deck.Shuffle();
            deck.Deal(playerCount);
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