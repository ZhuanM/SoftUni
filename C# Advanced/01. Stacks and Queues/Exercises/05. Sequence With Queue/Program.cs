using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sequence_With_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<long> numQueue = new Queue<long>
				(new []{long.Parse(Console.ReadLine())});

	        string answer = "";
	        for (int i = 0; i < 48; i++)
	        {
		        long currNum = numQueue.Peek();
		        numQueue.Enqueue(currNum + 1);
		        numQueue.Enqueue(2 * currNum + 1);
		        numQueue.Enqueue(currNum + 2);

		        answer += numQueue.Dequeue() + " ";
	        }

			// A little ugly but better than the queue having 2 more nums.
			answer += numQueue.Dequeue() + " " + numQueue.Dequeue();

            Console.WriteLine(answer);
        }
    }
}