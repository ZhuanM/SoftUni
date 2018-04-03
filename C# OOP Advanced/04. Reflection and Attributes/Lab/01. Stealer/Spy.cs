using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;


public class Spy
{
    public string StealFieldInfo(string classToInvestigate, params string[] fieldsToInvestigate)
    {
        StringBuilder sb = new StringBuilder($"Class under investigation: {classToInvestigate}" + Environment.NewLine);

        FieldInfo[] fields = Type.GetType(classToInvestigate)
            .GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);

        object classInstance = Activator.CreateInstance(Type.GetType(classToInvestigate)); // We use this instance so we can get the value of the field we are searching for

        foreach (var field in fields)
        {
            if (fieldsToInvestigate.Contains(field.Name))
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }
        }

        return sb.ToString().Trim(); // Trim is used to trim the last empty line left from the .AppendLine method
    }
}