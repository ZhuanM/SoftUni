using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participants =
                Console.ReadLine()
                .Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> songs = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var participantDict = new Dictionary<string, SortedSet<string>>(); //singer with awards
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "dawn")
                {
                    break;
                }

                string[] inputArgs = input.Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries);

                string singer = inputArgs[0];
                string song = inputArgs[1];
                string award = inputArgs[2];

                if (!participants.Contains(singer) || !songs.Contains(song))
                {
                    continue;
                }

                if (!participantDict.ContainsKey(singer))
                {
                    participantDict.Add(singer, new SortedSet<string>());
                }
                participantDict[singer].Add(award);
            }

            if (participantDict.Count == 0)
            {
                Console.WriteLine("No awards");
            }

            foreach (var participant in participantDict.OrderByDescending(p => p.Value.Count).ThenBy(p => p.Key))
            {
                Console.WriteLine($"{participant.Key}: {participant.Value.Count} awards");
                foreach (var award in participant.Value)
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }
    }
}