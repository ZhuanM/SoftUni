using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Forum.Data
{
    class DataMapper
    {
        private const string DATA_PATH = "../data/";
        private const string CONFIG_PATH = "config.ini";

        private const string DEFAULT_CONFIG = "users=users.csv\r\ncategories=categories.csv\r\nposts=posts.csv\r\nreplies=replies.csv";
        private static readonly Dictionary<string, string> config;

        private static void EnsureConfigFile(string configPath)
        {
            if (!File.Exists(configPath))
            {
                File.WriteAllText(configPath, DEFAULT_CONFIG);
            }
        }

        private static void EnsureFile(string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
        }

        private static string[] ReadLines(string path)
        {
            EnsureFile(path);
            string[] lines = File.ReadAllLines(path);
            return lines;
        }

        private static Dictionary<string, string> LoadConfig(string configPath)
        {
            EnsureConfigFile(configPath);
            string[] lines = ReadLines(configPath);

            Dictionary<string, string> result = lines
                .Select(l => l.Split('='))
                .ToDictionary(l => l[0], l => DATA_PATH + l[1]);

            return result;
        }
    }
}