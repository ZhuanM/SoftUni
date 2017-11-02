using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine().Split(new char[] { ',', ' ' },
               StringSplitOptions.RemoveEmptyEntries)
               .ToList();
            List<string> songs = Console.ReadLine().Split(new string[] { ", " },
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string[] gettingAward = Console.ReadLine().Split(new string[] { ", " },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Dictionary<string, SortedSet<string>> dict =
                new Dictionary<string, SortedSet<string>>();


            while (gettingAward[0] != "dawn")
            {
                string participant = gettingAward[0];
                string song = gettingAward[1];
                string award = gettingAward[2];

                if (participants.Contains(participant) && songs.Contains(song))
                {
                    if (!dict.ContainsKey(participant))
                    {
                        dict.Add(participant, new SortedSet<string>());
                    }

                    if (!dict[participant].Contains(award))
                    {
                        dict[participant].Add(award);
                    }

                }
                gettingAward = Console.ReadLine().Split(new string[] { ", " },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            }

            if (dict.Count < 1)
            {
                Console.WriteLine("No awards");
            }
            else
            {

                foreach (var item in dict.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    var items = item.Value;

                    if (item.Value.Count > 0)
                    {
                        Console.WriteLine(item.Key + ": " + items.Count + " awards");
                    }

                    foreach (var l in items)
                    {
                        Console.WriteLine("--" + l);
                    }
                }
            }
        }
    }
}