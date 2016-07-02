namespace _02.OldestFamilyMember
{
    using System;
    using System.Reflection;

    public class Startup
    {
        public static void Main()
        {
            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            if (oldestMemberMethod == null || addMemberMethod == null)
            {
                throw new Exception();
            }

            var family = new Family();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                family.AddMember(new Person(tokens[0], int.Parse(tokens[1])));
            }

            Person oldestFamilyMember = family.GetOldestMember();

            Console.WriteLine(oldestFamilyMember.name + " " + oldestFamilyMember.age);
        }
    }
}
