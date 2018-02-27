using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class InvalidSongSecondsException : InvalidSongLengthException
{
    public InvalidSongSecondsException() : base()
    {
    }

    public InvalidSongSecondsException(string message) : base(message)
    {
    }

    public InvalidSongSecondsException(int minSongSeconds, int maxSongSeconds)
        : base($"Song seconds should be between {minSongSeconds} and {maxSongSeconds}.")
    {
    }
}