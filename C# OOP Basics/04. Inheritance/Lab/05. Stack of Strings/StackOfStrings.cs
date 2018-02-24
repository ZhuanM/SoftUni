using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class StackOfStrings
{
    List<string> data = new List<string>();

    public bool IsEmpty()
    {
        return data.Count == 0; // Returns True or False according to whether data.Count is 0 or not
    }

    public void Push(string item)
    {
        data.Add(item);
    }

    public string Peek()
    {
        string result = string.Empty;
        if (!IsEmpty()) // If list NOT empty
        {
            int lastIndex = data.Count - 1;
            result = data[lastIndex];
        }

        return result;
    }

    public string Pop()
    {
        string result = string.Empty;
        if (!IsEmpty()) // If list NOT empty
        {
            int lastIndex = data.Count - 1;
            result = data[lastIndex];

            data.RemoveAt(lastIndex);
        }

        return result;
    }
}