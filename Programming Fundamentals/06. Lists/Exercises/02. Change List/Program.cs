using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            string line = Console.ReadLine();

            while (!(line == "Even" || line == "Odd"))
            {
                var tokens = line.Split();
                var command = tokens[0];

                if (command == "Delete")
                {
                    var element = int.Parse(tokens[1]);
                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (nums[i] == element)
                        {
                            nums.Remove(element);
                            i--;
                        }
                    }
                }
                else if (command == "Insert")
                {
                    var element = int.Parse(tokens[1]);
                    var index = int.Parse(tokens[2]);
                    nums.Insert(index, element);
                }

                line = Console.ReadLine();              
            }

            if (line == "Even")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] % 2 == 0)
                    {
                        Console.Write(nums[i] + " ");
                    }
                }
            }
            else if (line == "Odd")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] % 2 != 0)
                    {
                        Console.Write(nums[i] + " ");
                    }
                }
            }
        }
    }
}