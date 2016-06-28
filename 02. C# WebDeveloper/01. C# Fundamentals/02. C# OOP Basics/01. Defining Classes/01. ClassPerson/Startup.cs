namespace _01.ClassPerson
{
    using System;
    using System.Reflection;

    public class Startup
    {
        public static void Main()
        {
            Type personType = typeof (Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);
        }
    }
}
