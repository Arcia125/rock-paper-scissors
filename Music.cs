using System;
using System.Threading;
using RPSNote;

namespace RPSMusic
{
  class Music
  {
    internal static Note[] Intro = {
        new Note(Tone.A, Duration.SIXTEENTH),
        new Note(Tone.B, Duration.SIXTEENTH),
        new Note(Tone.A, Duration.SIXTEENTH),
        new Note(Tone.B, Duration.QUARTER)
    };

    internal static Note[] PickPrompt = {
        new Note(Tone.C, Duration.EIGHTH),
        new Note(Tone.C, Duration.SIXTEENTH),
        new Note(Tone.A, Duration.SIXTEENTH)
    };

    internal static Note[] InvalidInput = {
        new Note(Tone.F, Duration.SIXTEENTH),
        new Note(Tone.F, Duration.SIXTEENTH),
        new Note(Tone.F, Duration.SIXTEENTH),
        new Note(Tone.F, Duration.SIXTEENTH)
    };

    internal static Note[] Win = {
        new Note(Tone.Dsharp, Duration.QUARTER),
        new Note(Tone.Fsharp, Duration.QUARTER),
        new Note(Tone.GbelowC, Duration.QUARTER),
        new Note(Tone.Csharp, Duration.HALF)
    };
           
    internal static Note[] Draw = {
        new Note(Tone.Csharp, Duration.HALF)
    };

    internal static Note[] Lose = {
        new Note(Tone.C, Duration.EIGHTH),
        new Note(Tone.B, Duration.EIGHTH),
        new Note(Tone.C, Duration.EIGHTH),
        new Note(Tone.B, Duration.SIXTEENTH),
        new Note(Tone.Asharp, Duration.HALF)
    };

    public static void Play(Note[] notes)
    {
      foreach (Note n in notes)
      {
        if (n.NoteTone == Tone.REST)
          Thread.Sleep((int)n.NoteDuration);
        else
          Console.Beep((int)n.NoteTone, (int)n.NoteDuration);
      }
    }
  }
}
