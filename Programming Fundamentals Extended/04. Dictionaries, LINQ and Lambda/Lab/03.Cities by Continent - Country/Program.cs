using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Cities_by_Continent___Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            var continentsData = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var continet = tokens[0];
                var country = tokens[1];
                var city = tokens[2];

                if (!continentsData.ContainsKey(continet))
                {
                    continentsData[continet] = new Dictionary<string, List<string>>();
                }

                var currentContinent = continentsData[continet];
                if (!continentsData[continet].ContainsKey(country))
                {
                    currentContinent[country] = new List<string>();
                }

                var currentCountry = currentContinent[country];
                currentCountry.Add(city);
            }

            foreach (var continent in continentsData)
            {
                Console.WriteLine(continent.Key + ":");

                var countries = continent.Value;
                foreach (var country in countries)
                {
                    var countryName = country.Key;
                    var countryCities = country.Value;
                    Console.WriteLine("  {0} -> {1}", countryName, string.Join(", ", countryCities));
                }
            }
        }
    }
}