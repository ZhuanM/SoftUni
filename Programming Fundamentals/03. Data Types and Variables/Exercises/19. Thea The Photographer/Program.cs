using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int allPictures = int.Parse(Console.ReadLine());
            int secondsToFilterOnePic = int.Parse(Console.ReadLine());
            double percentageOfGoodPics = double.Parse(Console.ReadLine());
            int secondsToUploadOnePic = int.Parse(Console.ReadLine());

            int filteredPics = (int)Math.Ceiling((percentageOfGoodPics / 100) * allPictures);
            int secondsToFilterPics = allPictures * secondsToFilterOnePic;
            int secondsToUploadFilteredPics = filteredPics * secondsToUploadOnePic;
            int totalTimeInSeconds = secondsToUploadFilteredPics + secondsToFilterPics;

            TimeSpan dateFormat = TimeSpan.FromSeconds(totalTimeInSeconds);
            string allTime = dateFormat.ToString(@"d\:hh\:mm\:ss");

            Console.WriteLine(allTime);
        }
    }
}