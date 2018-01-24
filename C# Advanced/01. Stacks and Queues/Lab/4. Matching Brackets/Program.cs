using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<int> stackOpenBracketIndexes = new Stack<int>();

            for (int index = 0; index < input.Length; index++)
            {
                if (input[index] == '(')
                {
                    stackOpenBracketIndexes.Push(index);
                }

                if (input[index] == ')')
                {
                    var openBracketIndex = stackOpenBracketIndexes.Pop();
                    var length = index - openBracketIndex + 1; //+ 1 because otherwise we will miss the closing bracket

                    Console.WriteLine(input.Substring(openBracketIndex, length));
                }
            }
        }
    }
}