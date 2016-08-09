namespace _02.BlackBoxInteger
{
    using System;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            var typeBlackBox = typeof(BlackBoxInt);
            var constructorBlackBox = typeBlackBox.GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, null, Type.EmptyTypes, null);
            var objectBlackBox = constructorBlackBox?.Invoke(new object[0]);

            string input = Console.ReadLine();
            while (input != "END")
            {
                var tokens = input.Split(new char[] {'_'}, StringSplitOptions.RemoveEmptyEntries);

                var methodWanted = tokens[0];
                var value = int.Parse(tokens[1]);

                var typeMethod = typeBlackBox.GetMethod(methodWanted, BindingFlags.NonPublic | BindingFlags.Instance);
                typeMethod.Invoke(objectBlackBox, new object[] {value});

                var typeField = typeBlackBox.GetField("innerValue", BindingFlags.NonPublic | BindingFlags.Instance);
                Console.WriteLine(typeField?.GetValue(objectBlackBox));

                input = Console.ReadLine();
            }
        }
    }
}
