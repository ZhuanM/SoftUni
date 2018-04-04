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

    public string AnalyzeAcessModifiers(string classToInvestigate)
    {
        Type type = Type.GetType(classToInvestigate);

        StringBuilder sb = new StringBuilder();

        FieldInfo[] fields = type.GetFields();
        foreach (var field in fields)
        {
            sb.AppendLine(field.Name + " must be private!");
        }

        PropertyInfo[] properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
        foreach (var property in properties)
        {
            if (property.GetMethod?.IsPrivate == true)
            {
                sb.AppendLine(property.GetMethod.Name + " have to be public!");
            }
        }
        foreach (var property in properties)
        {
            if (property.SetMethod?.IsPublic == true)
            {
                sb.AppendLine(property.SetMethod.Name + " have to be private!");
            }
        }

        return sb.ToString().Trim(); // Trim is used to trim the last empty line left from the .AppendLine method
    }

    public string RevealPrivateMethods(string classToInvestigate)
    {
        Type type = Type.GetType(classToInvestigate);
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"All Private Methods of Class: {classToInvestigate}");
        sb.AppendLine($"Base Class: {type.BaseType.Name}");

        MethodInfo[] nonPublicMethods = type.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
        foreach (var method in nonPublicMethods)
        {
            sb.AppendLine(method.Name);
        }

        return sb.ToString().Trim(); // Trim is used to trim the last empty line left from the .AppendLine method
    }
}