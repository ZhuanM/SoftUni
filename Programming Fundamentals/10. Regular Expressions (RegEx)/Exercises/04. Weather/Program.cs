﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> citiesWithTemperature = new Dictionary<string, double>();
            Dictionary<string, string> citiestWithWeather = new Dictionary<string, string>();

            string pattern = @"([A-Z]{2})(\d+\.\d+)([A-Za-z]+)\|";

            string input = Console.ReadLine();

            while (input != "end")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Match match = Regex.Match(input, pattern);

                    string city = match.Groups[1].Value;
                    double averageTemp = double.Parse(match.Groups[2].Value);
                    string weather = match.Groups[3].Value;

                    citiesWithTemperature[city] = averageTemp;
                    citiestWithWeather[city] = weather;
                }

                input = Console.ReadLine();
            }

            Dictionary<string, double> sortedCitiesByTemperature =
                citiesWithTemperature.OrderBy(c => c.Value).ToDictionary(x => x.Key, x => x.Value);

            foreach (var sortedCity in sortedCitiesByTemperature)
            {
                Console.WriteLine($"{sortedCity.Key} => {sortedCity.Value} => {citiestWithWeather[sortedCity.Key]}");
            }
        }
    }
}