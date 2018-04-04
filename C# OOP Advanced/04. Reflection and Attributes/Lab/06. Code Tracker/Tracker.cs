using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;


public class Tracker
{
    public static void PrintMethodsByAuthor()
    {
        Type type = typeof(StartUp);

        MethodInfo[] methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic);
        foreach (var method in methods)
        {
            IEnumerable<SoftUniAttribute> attributes = method.GetCustomAttributes<SoftUniAttribute>();
            foreach (var attribute in attributes)
            {
                Console.WriteLine(attribute.Name);
            }
        }
    }
}