using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Anonymous_Cache
{
    class Program
    {
        static void Main(string[] args)
        {            
            string input = Console.ReadLine();

            List<string> dataSetList = new List<string>(); //contains only dataSet names
            var dataSetInfo = new Dictionary<string, Dictionary<string, long>>(); //contains dataKey -> dataSize
            while (input != "thetinggoesskrra")
            {
                string[] data = input.Split("->| ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                if (data.Length == 1) // if the input contains only 1 string which is the dataSet
                {
                    string dataSet = data[0];
                    dataSetList.Add(dataSet);
                }
                else
                {
                    string dataKey = data[0];
                    long dataSize = long.Parse(data[1]);
                    string dataSet = data[2];

                    if (!dataSetInfo.ContainsKey(dataSet))
                    {
                        dataSetInfo.Add(dataSet, new Dictionary<string, long>());
                    }
                    dataSetInfo[dataSet][dataKey] = dataSize;
                }

                input = Console.ReadLine();
            }

            //FOR SOME REASON THE SOLUTION IS MARKED 100/100 EVEN WITHOUT THE FOLLOWING FILTRATION WHERE I HAVE TO REMOVE CERTAIN ELEMENTS 
            //if the dataSet was NOT initialized before adding values to it => remove it (because I've made it so everything gets added no matter if it's initialized or not)
            dataSetInfo
                .ToList() //list of dictionaries
                .Where(e => !dataSetList.Contains(e.Key))
                .ToList() //makes a list of the e.Key that are NOT contained in the dataSetList
                .ForEach(e => dataSetInfo.Remove(e.Key));

            if (dataSetInfo.Count > 0)
            {
                //orders the sum of dataSizes of different dataSets by descending and takes the first highest sum of them all
                var result = dataSetInfo.OrderByDescending(x => x.Value.Sum(e => e.Value)).First();

                Console.WriteLine($"Data Set: {result.Key}, Total Size: {result.Value.Sum(e => e.Value)}");

                foreach (var item in result.Value)
                {
                    Console.WriteLine($"$.{item.Key}");
                }
            }
        }
    }
}