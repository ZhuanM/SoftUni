using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

public class FieldCollector
{
    public string CollectPublicFields(string classToInvestigate)
    {
        Type type = Type.GetType(classToInvestigate);
        FieldInfo[] publicFields = type.GetFields(BindingFlags.Instance | BindingFlags.Public);

        StringBuilder sb = new StringBuilder();
        foreach (var field in publicFields)
        {
            sb.AppendLine($"public {field.FieldType.Name} {field.Name}");
        }

        return sb.ToString().Trim();
    }

    public string CollectProtectedFields(string classToInvestigate)
    {
        Type type = Type.GetType(classToInvestigate);
        FieldInfo[] publicFields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

        StringBuilder sb = new StringBuilder();
        foreach (var field in publicFields)
        {
            if (field.IsFamily)
            {
                sb.AppendLine($"protected {field.FieldType.Name} {field.Name}");
            }
        }

        return sb.ToString().Trim();
    }

    public string CollectPrivateFields(string classToInvestigate)
    {
        Type type = Type.GetType(classToInvestigate);
        FieldInfo[] publicFields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

        StringBuilder sb = new StringBuilder();
        foreach (var field in publicFields)
        {
            if (field.IsPrivate)
            {
                sb.AppendLine($"private {field.FieldType.Name} {field.Name}");
            }
        }

        return sb.ToString().Trim();
    }

    public string CollectAllFields(string classToInvestigate)
    {
        Type type = Type.GetType(classToInvestigate);
        FieldInfo[] publicFields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

        StringBuilder sb = new StringBuilder();
        foreach (var field in publicFields)
        {
            string accessModifier = field.IsPublic ? "public" : field.IsPrivate ? "private" : "protected";

            sb.AppendLine($"{accessModifier} {field.FieldType.Name} {field.Name}");
        }

        return sb.ToString().Trim();
    }
}