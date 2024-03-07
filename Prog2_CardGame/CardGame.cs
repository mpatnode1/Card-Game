using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static Prog2_CardGame.Utility;

namespace Prog2_CardGame
{
    public class CardGame
    {
        protected int playerCount;
        private string gameRule;
        protected List<CardPile> PlayerHands = new List<CardPile>();
        protected CardPile DrawPile = new CardPile(RNG);

        protected int WinScore;
        protected int[] Score;
        protected int Rounds;

        protected static Random RNG = new Random();

        public CardGame(int playerCount, CardPile StartingPile)
        {
           
            DrawPile = StartingPile;
            if (playerCount == 0)
            {
                Score = new int [1];
            }
            else
            {
                Score = new int[playerCount];
            }
            
            for (int i = 0; i < playerCount + 1; i++) 
            {
                PlayerHands.Add(new CardPile(RNG));
            }
                
        }
        /// <summary>
        /// Print all current players scores.
        /// </summary>
        protected void PrintScore()
        {
            for (int i = 0; i < Score.Length; i++)
            {
                Print($"Player {i + 1} Score: {Score[i]}");

            }
        }

        protected int? CheckWin()
        {
            for (int i = 0; i < Score.Length; i++)
            {
                if (Score[i] == WinScore)
                {
                    Print($"Player {i + 1} has won");
                    return i;
                }

            }
            return null;
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

        
    }
}
/*
          * Debug Deck
          * 
          * Console.WriteLine(deck);
         Console.WriteLine("HAMBURGER");
         var temp = PlayerHands[0];
         var draw = deck.Draw(3);
         temp.AddRange(draw);
         Console.WriteLine("HAMBURGER");
         Console.WriteLine(PlayerHands[0]);
         Console.WriteLine("HAMBURGER");
         Console.WriteLine(deck); */