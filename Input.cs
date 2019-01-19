using System;
using System.Collections.Generic;
using RPSMusic;

namespace RPSInput
{
    public class Input
    {
        private static string[] Choices = new string[] { "rock", "paper", "scissors" };

        private static Dictionary<string, string> PlayerInputs = new Dictionary<string, string>()
        {
          { "r", "rock" },
          { "p", "paper" },
          { "s", "scissors" },
          { "rock", "rock" },
          { "paper", "paper" },
          { "scissors", "scissors" },
        };

        private static Dictionary<string, string> PlayAgainInputs = new Dictionary<string, string>()
        {
            { "y", "yes" },
            { "yes", "yes" },
            { "n", "no" },
            { "no", "no" }
        };
        public static string GetPlayerInput()
        {
            Music.Play(Music.PickPrompt);
            return GetValidInput("enter your choice (R, P, S):", "you have entered an invalid choice, please try again, the valid choices are R, P, and S:", Input.PlayerInputs);
        }

        private static string GetValidInput(string promptMessage, string invalidMessage, Dictionary<string, string> validDictionary)
        {
            Console.WriteLine(promptMessage);
            ConsoleKeyInfo playerInputKeyInfo = Console.ReadKey();
            string playerInput = playerInputKeyInfo.KeyChar.ToString().ToLower();
            bool inputIsValid = false;
            while (!inputIsValid)
            {
                inputIsValid = validDictionary.ContainsKey(playerInput);
                if (!inputIsValid)
                {
                    Music.Play(Music.InvalidInput);
                    Console.WriteLine(invalidMessage);
                    playerInputKeyInfo = Console.ReadKey();
                    playerInput = playerInputKeyInfo.KeyChar.ToString().ToLower();
                }
                Console.WriteLine("");
            }
            return validDictionary[playerInput.ToLower()];
        }

        public static string GetComputerInput()
        {
            Random r = new Random();
            return Choices[r.Next(Choices.Length)];
        }
        public static bool PlayAgain()
        {
            string playAgain = GetValidInput("Would you like to play again (y/n)?:", "you have entered an invalid choice, please try again, the valid choices are y and n:", PlayAgainInputs);
            return playAgain == PlayAgainInputs["yes"];
        }
    }
}
