namespace _04.MordorCrueltyPlan
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var foods = Console.ReadLine()
                .ToUpper()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            var gandalf = new Gandalf();

            foreach (var food in foods)
            {
                if (food == "CRAM")
                {
                    Food f = new Cram();
                    gandalf.Eat(f);
                }
                else if (food == "LEMBAS")
                {
                    Food f = new Lembas();
                    gandalf.Eat(f);
                }
                else if (food == "APPLE")
                {
                    Food f = new Apple();
                    gandalf.Eat(f);
                }
                else if (food == "MELON")
                {
                    Food f = new Melon();
                    gandalf.Eat(f);
                }
                else if (food == "HONEYCAKE")
                {
                    Food f = new HoneyCake();
                    gandalf.Eat(f);
                }
                else if (food == "MUSHROOMS")
                {
                    Food f = new Mushrooms();
                    gandalf.Eat(f);
                }
                else
                {
                    Food f = new OtherFood();
                    gandalf.Eat(f);
                }
            }

            Console.WriteLine(gandalf.Hapiness);
            Console.WriteLine(gandalf.GetMood());
        }
    }
}
