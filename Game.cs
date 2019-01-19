using System;
using System.Collections.Generic;
using RPSMusic;
using RPSOutcome;
using RPSInput;

namespace RPSGame
{
    class Game
    {

        public void Start()
        {
            Music.Play(Music.Intro);
            GameLoop();
        }

        public void GameLoop()
        {
            bool playAgain = true;
            while (playAgain)
            {
                string playerInput = Input.GetPlayerInput();
                string computerInput = Input.GetComputerInput();
                GameOutcome.AnnounceGameOutcome(GameOutcome.CheckForWinner(playerInput, computerInput), playerInput, computerInput);

                playAgain = Input.PlayAgain();
                if (playAgain)
                    Console.WriteLine("");
            }
        }
    }
}
