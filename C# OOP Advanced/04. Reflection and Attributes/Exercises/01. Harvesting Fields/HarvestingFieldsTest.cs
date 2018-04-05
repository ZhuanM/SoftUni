using System;

public class HarvestingFieldsTest
{
    public static void Main()
    {
        FieldCollector fc = new FieldCollector();

        string input;
        while ((input = Console.ReadLine()) != "HARVEST")
        {
            switch (input)
            {
                case "public":
                    string publicFields = fc.CollectPublicFields("HarvestingFields");
                    Console.WriteLine(publicFields);
                    break;
                case "protected":
                    string protectedFields = fc.CollectProtectedFields("HarvestingFields");
                    Console.WriteLine(protectedFields);
                    break;
                case "private":
                    string privateFields = fc.CollectPrivateFields("HarvestingFields");
                    Console.WriteLine(privateFields);
                    break;
                case "all":
                    string allFields = fc.CollectAllFields("HarvestingFields");
                    Console.WriteLine(allFields);
                    break;
            }
        }
    }
}