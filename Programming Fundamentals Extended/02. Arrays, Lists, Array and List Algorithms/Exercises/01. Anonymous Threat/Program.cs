using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements =
                Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = Console.ReadLine();

            while (!input.Equals("3:1"))
            {
                string[] commands = input.Split();
                string command = commands[0];
                int startIndex = int.Parse(commands[1]);
                int endIndex = int.Parse(commands[2]);

                if (startIndex < 0 || startIndex > elements.Count - 1)
                {
                    startIndex = 0;
                }

                if (endIndex < 0 || endIndex > elements.Count - 1)
                {
                    endIndex = elements.Count - 1;
                }

                switch (command)
                {
                    case "merge":
                        elements = Merge(elements, startIndex, endIndex);

                        break;                
                    case "divide":
                        int wordToDivide = int.Parse(commands[1]);
                        int partitionsCount = int.Parse(commands[2]);

                        elements = Divide(elements, wordToDivide, partitionsCount);

                        break;
                }

                input = Console.ReadLine();
            }

            //PRINT OUTPUT
            Console.WriteLine(string.Join(" ", elements));
        }

        private static List<string> Merge(List<string> elements, int startIndex, int endIndex)
        {
            //Lets create a new list
            List<string> newList = new List<string>();

            //Lets add everything up until the startIndex in the new list.
            for (int i = 0; i < startIndex; i++)
            {
                newList.Add(elements[i]);
            }

            //Lets get a StringBuilder, since we will be appending strings (merging)
            StringBuilder result = new StringBuilder();

            //Lets merge the elements we need to merge
            for (int i = startIndex; i <= endIndex; i++)
            {
                result.Append(elements[i]);
            }

            //Lets add the newly merged element to the new list
            newList.Add(result.ToString());

            //Lets add all other elements after the mergin indexes to the newlist
            for (int i = endIndex + 1; i < elements.Count; i++)
            {
                newList.Add(elements[i]);
            }

            //A new list with all old elements, except the merged ones, which are a totally new SINGLE element.
            return newList;
        }

        private static List<string> Divide(List<string> sensitiveData, int index, int partitions)
        {
            //Get the element at that index.
            //It was said in the Constraints section that it will always be a valid index
            string element = sensitiveData[index];

            //Lets integer divide the element's length into the partitions to get the minimal length
            //the elements should have
            int partitionLength = element.Length / partitions;

            //Lets get a new list of the partitions
            List<string> dividedPartitions = new List<string>();

            //Lets get a loop for all the partitions
            for (int i = 0; i < partitions; i++)
            {
                //If its the last element
                if (i == partitions - 1)
                {
                    //Just add everything after it, so that it is the longest one
                    //In other words, accoarding to the description, we must make the LAST element - the LONGEST
                    dividedPartitions.Add(element.Substring(i * partitionLength));
                }
                else
                {
                    //If its not the last element, just add a substring from its index
                    //and cut "partitionLength" amount of characters
                    dividedPartitions.Add(element.Substring(i * partitionLength, partitionLength));
                }
            }

            //Now whats the logic with the i * partitionLength

            //EXAMPLE NO.1: We have "abcdef" we want to divide it by 4.
            //partitionLength = element.Length (6) / partition (4) = 1 (integer division)
            //for (i = 0; i < 4; i++)
            //First iteration - i = 0. 0 * 1 = 0. Start index - 0, length - 1, Substring result - "a"
            //Second iteration - i = 1. 1 * 1 = 1. Start index - 1, length - 1, Substring result - "b"
            //Third iteration - i = 2. 2 * 1 = 2. Start index - 2, length - 1, Substring result - "c"
            //Fourth iteration (FINAL ITERATION) - i = 3, 3 * 1 = 3. Start index - 3, length - none, Substring result - "def"

            //EXAMPLE NO.2: Lets try with a longer string. 
            //We have "123456789" we want to divide it by 4.
            //partitionLength = element.Length (9) / partition (4) = 2 (integer division)
            //for (i = 0; i < 4; i++)
            //First iteration - i = 0. 0 * 2 = 0. Start index - 0, length - 2, Substring result - "12"
            //Second iteration - i = 1. 1 * 2 = 2. Start index - 2, length - 2, Substring result - "34"
            //Third iteration - i = 2. 2 * 2 = 4. Start index - 4, length - 2, Substring result - "56"
            //Fourth iteration (FINAL ITERATION) - i = 3, 3 * 2 = 6. Start index - 6, length - none, Substring result - "789"

            //Then lets just remove the old element from the array
            sensitiveData.RemoveAt(index);
            //Then lets just InsertRange the new partitions at that index
            sensitiveData.InsertRange(index, dividedPartitions);

            //Then we get a list with the new divided data in it.
            return sensitiveData;
        }
    }
}