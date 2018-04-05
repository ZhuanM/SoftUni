using System.Reflection;

namespace _02._Black_Box_Integer
{
    using System;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            Type classType = typeof(BlackBoxInteger);
            BlackBoxInteger instance = (BlackBoxInteger) Activator.CreateInstance(classType, true);

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split('_');

                string methodName = tokens[0];
                int value = int.Parse(tokens[1]);

                classType
                    .GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic)
                    .Invoke(instance, new object[] { value });

                int currentValue = (int) classType
                    .GetField("innerValue", BindingFlags.Instance | BindingFlags.NonPublic)
                    .GetValue(instance);

                Console.WriteLine(currentValue);
            }
        }
    }
}
