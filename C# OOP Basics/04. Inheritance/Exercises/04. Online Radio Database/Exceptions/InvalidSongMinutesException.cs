using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class InvalidSongMinutesException : InvalidSongLengthException
{
    public InvalidSongMinutesException() : base()
    {
    }

    public InvalidSongMinutesException(string message) : base(message)
    {
    }

    public InvalidSongMinutesException(int minSongMinutes, int msxSongMinutes)
        : base($"Song minutes should be between {minSongMinutes} and {msxSongMinutes}.")
    {
    }
}