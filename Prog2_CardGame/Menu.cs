using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Prog2_CardGame.Utility;
using static System.Console;

namespace Prog2_CardGame
{
    public class Menu
    {
        private int playerCount;
        public Menu()
        {
            Print("Welcome to a Super Awesome Card Game!");
            Pause();
            IPlay GameChoice = MenuInput();
            Print("Do you want to hear instructions?");
            Print("Type for Yes type 1 and No type 2");
            char instructInput;
            bool instructBreak = true;
            while (instructBreak == true)
            {
                instructInput = ReadKey().KeyChar;
                Print("");
                switch (instructInput)
                {
                    case '1':
                        GameChoice.Instructions();
                        instructBreak = false;
                        break;
                    case '2':
                        instructBreak = false;
                        break;
                    default:
                        Print("Please type in a number.");
                        break;
                }

            }
            GameChoice.Setup();
            GameChoice.Play();
        }
       
       

        public IPlay MenuInput()
        {
            char input;
            Print("Type a number to select which card game you would like to play, or view credits.");
            Print("1. Same Or Different");
            Print("2. Higher Or Lower");
            Print("3. Highest Match");
            Print("4. View Credits");
            
            while (true)
            {
                input = ReadKey().KeyChar;
                Print("");
                switch (input)
                {
                    case '1':
                        return new SameOrDifferent();
                    case '2':
                        return new HigherOrLower();
                    case '3':
                        return new HighestMatch();
                    case '4':
                        Print("Credits");
                        Pause();
                        break;
                    default:
                        Print("Please type in a number.");
                        break;
                }
                
            }
            


        }
        //welcome player to system
        //pick a game
        // 1. Apples and Oranges
        //ReadKey();
        //if 1 set string game = "ApplesAndOranges"
        //switch to game.cs
        



        public void Quit()
        {
            throw new System.NotImplementedException();
        }
    }
}