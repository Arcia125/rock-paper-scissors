using System;
using RPSMusic;

namespace RPSOutcome
{
    public enum Outcome
    {
        PLAYER1WINS = 1,
        DRAW = 0,
        PLAYER2WINS = -1,
    }

    public class GameOutcome
    {
        public static Outcome CheckForWinner(string player1Input, string player2Input)
        {
            Func<string, Func<string, bool>> isX = x => str => x == str;
            Func<string, bool> isRock = isX("rock");
            Func<string, bool> isScissors = isX("scissors");
            Func<string, bool> isPaper = isX("paper");

            bool player1IsRock = isRock(player1Input);
            bool player1IsScissors = isScissors(player1Input);
            bool player1IsPaper = isPaper(player1Input);

            bool player2IsRock = isRock(player2Input);
            bool player2IsScissors = isScissors(player2Input);
            bool player2IsPaper = isPaper(player2Input);

            if (isRock(player1Input))
            {
                if (player2IsScissors)
                {
                    return Outcome.PLAYER1WINS;
                }
                if (player2IsRock)
                {
                    return Outcome.DRAW;
                }
                if (player2IsPaper)
                {
                    return Outcome.PLAYER2WINS;
                }
            }

            if (player1IsScissors)
            {
                if (player2IsPaper)
                {
                    return Outcome.PLAYER1WINS;
                }
                if (player2IsScissors)
                {
                    return Outcome.DRAW;
                }
                if (player2IsRock)
                {
                    return Outcome.PLAYER2WINS;
                }
            }

            if (player1IsPaper)
            {
                if (player2IsRock)
                {
                    return Outcome.PLAYER1WINS;
                }
                if (player2IsPaper)
                {
                    return Outcome.DRAW;
                }
                if (player2IsScissors)
                {
                    return Outcome.PLAYER2WINS;
                }
            }

            return Outcome.DRAW;

        }
        public static void AnnounceGameOutcome(Outcome outcome, string p1Input, string p2input)
        {
            if (outcome == Outcome.PLAYER1WINS)
            {
                Music.Play(Music.Win);
                Console.WriteLine("You win. You chose: {0} and the computer chose {1}.", p1Input, p2input);
            }
            else if (outcome == Outcome.PLAYER2WINS)
            {
                Music.Play(Music.Lose);
                Console.WriteLine("The computer won. You chose: {0} and the computer chose {1}.", p1Input, p2input);
            }
            else
            {
                Music.Play(Music.Draw);
                Console.WriteLine("The match was a draw. You chose: {0} and the computer chose {1}.", p1Input, p2input);
            }
        }
    }
}
