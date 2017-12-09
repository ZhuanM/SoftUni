using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> elements = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> removedElements = new List<int>();

            while (elements.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    index = 0;
                    removedElements.Add(elements[index]);
                    elements.RemoveAt(index);
                    int lastElement = elements[elements.Count - 1];
                    elements.Insert(0, lastElement);

                    IncreaseAndDecrease(elements, removedElements);
                }
                else if (index > elements.Count - 1)
                {
                    index = elements.Count - 1;
                    removedElements.Add(elements[index]);
                    elements.RemoveAt(index);
                    int firstElement = elements[0];
                    elements.Insert(index, firstElement);

                    IncreaseAndDecrease(elements, removedElements);
                }
                else
                {
                    removedElements.Add(elements[index]);
                    elements.RemoveAt(index);

                    IncreaseAndDecrease(elements, removedElements);
                }   
            }

            Console.WriteLine(removedElements.Sum());
        }

        static void IncreaseAndDecrease(List<int> elements, List<int> removedElements)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] <= removedElements[removedElements.Count - 1])
                {
                    elements[i] += removedElements[removedElements.Count - 1];
                }
                else if (elements[i] > removedElements[removedElements.Count - 1])
                {
                    elements[i] -= removedElements[removedElements.Count - 1];
                }
            }
        }
    }
}