using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder();
            Stack<string> oldVersions = new Stack<string>();           

            int n = int.Parse(Console.ReadLine());           
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                int command = int.Parse(input[0]);
                switch (command)
                {
                    case 1:
                        oldVersions.Push(text.ToString());

                        string stringToAppend = input[1];
                        text.Append(stringToAppend);
                        break;

                    case 2:
                        oldVersions.Push(text.ToString());

                        int length = int.Parse(input[1]);
                        text.Remove(text.Length - length, length);
                        break;

                    case 3:
                        int index = int.Parse(input[1]);
                        Console.WriteLine(text[index - 1]);
                        break;

                    case 4:
                        text.Clear();
                        text.Append(oldVersions.Pop());
                        break;
                }
            }
        }
    }
}