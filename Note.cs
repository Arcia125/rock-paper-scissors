using System;

namespace RPSNote
{
    public enum Tone
    {
        REST = 0,
        GbelowC = 196,
        A = 220,
        Asharp = 233,
        B = 247,
        C = 262,
        Csharp = 277,
        D = 294,
        Dsharp = 311,
        E = 330,
        F = 349,
        Fsharp = 370,
        G = 392,
        Gsharp = 415,
    }

    public struct Note
    {
        Tone toneVal;
        Duration durVal;

        public Note(Tone frequency, Duration time)
        {
            toneVal = frequency;
            durVal = time;
        }

        public Tone NoteTone { get { return toneVal; } }

        public Duration NoteDuration { get { return durVal; } }
    }

    public enum Duration
    {
        WHOLE = 1600,
        HALF = WHOLE / 2,
        QUARTER = HALF / 2,
        EIGHTH = QUARTER / 2,
        SIXTEENTH = EIGHTH / 2
    }
}
