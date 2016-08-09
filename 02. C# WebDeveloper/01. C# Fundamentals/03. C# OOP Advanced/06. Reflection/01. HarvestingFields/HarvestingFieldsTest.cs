namespace _01.HarvestingFields
{
    using System;
    using System.Reflection;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            var typeHarvestingFields = typeof (HarvestingFields);

            var input = Console.ReadLine();
            while (input != "HARVEST")
            {
                bool canPrintPrivate = false;
                bool canPrintProtected = false;
                bool canPrintPublic = false;

                if (input == "private")
                {
                    canPrintPrivate = true;
                }
                else if (input == "protected")
                {
                    canPrintProtected = true;
                }
                else if (input == "public")
                {
                    canPrintPublic = true;
                }
                else if (input == "all")
                {
                    canPrintPrivate = true;
                    canPrintProtected = true;
                    canPrintPublic = true;
                }

                PrintFields(typeHarvestingFields, canPrintPrivate, canPrintProtected, canPrintPublic);

                input = Console.ReadLine();
            }
        }

        public static void PrintFields(Type typeHarvestingFields, bool canPrintPrivate, bool canPrintProtected, bool canPrintPublic)
        {
            var allFields = typeHarvestingFields.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            foreach (var field in allFields)
            {
                if (field.IsPrivate && canPrintPrivate)
                {
                    PrintField(field, "private");
                }
                else if (field.IsFamily && canPrintProtected)
                {
                    PrintField(field, "protected");
                }
                else if (field.IsPublic && canPrintPublic)
                {
                    PrintField(field, "public");
                }
            }
        }

        public static void PrintField(FieldInfo field, string accessModifier)
        {
            Console.WriteLine($"{accessModifier} {field.FieldType.Name} {field.Name}");
        }
    }
}
