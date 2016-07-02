namespace _09.PizzaTime
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class Startup
    {
        public static void Main()
        {
            MethodInfo[] methods = typeof(Pizza).GetMethods();
            bool containsMethod = methods.Any(m => m.ReturnType.Name.Contains("SortedDictionary"));
            if (!containsMethod)
            {
                throw new Exception();
            }

            var dict = Pizza.GetGroupedPizzas(Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries));

            foreach (var group in dict)
            {
                Console.WriteLine($"{group.Key} - {string.Join(", ", group.Value)}");
            }
        }
    }
}
