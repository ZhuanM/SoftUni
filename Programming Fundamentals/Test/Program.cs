namespace Exercises_AnonymousDownsite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    public class Exercises_AnonymousDownsite
    {
        public static void Main()
        {
            int webSiteCnt = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());

            List<string> webSites = new List<string>();
            decimal totalLoss = 0;
            decimal siteLoss = 0;

            double securityToken = BigInteger.Pow(securityKey, webSiteCnt);


            for (int i = 0; i < webSiteCnt; i++)
            {

                string[] tokens = Console.ReadLine()
                    .Split(' ')
                    .ToArray();

                string siteName = tokens[0];
                long siteVisits = long.Parse(tokens[1]);
                decimal pricePerVisit = decimal.Parse(tokens[2]);

                webSites.Add(siteName);
                siteLoss = siteVisits * pricePerVisit;
                totalLoss += siteLoss;

            }

            Console.WriteLine(string.Join(Environment.NewLine, webSites));
            Console.WriteLine($"Total Loss: {totalLoss:F20}");
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}