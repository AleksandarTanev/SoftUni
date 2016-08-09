namespace _06.MirrorImage
{
    using System;
    using System.Linq;

    using Models;

    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var tokens = input.Split();

            string name = tokens[0];
            int magicalPower = int.Parse(tokens[1]);

            var wizzard = new Wizzard(name, magicalPower);

            input = Console.ReadLine();
            while (input != "END")
            {
                tokens = input.Split();

                int mageId = int.Parse(tokens[0]);
                string spell = tokens[1];

                var neededWizzard = Wizzard.allWizards.FirstOrDefault(w => w.Id == mageId);

                if (spell == "FIREBALL")
                {
                    neededWizzard?.CastFireBall();
                }
                else if (spell == "REFLECTION")
                {
                    neededWizzard?.CastReflection();
                }

                input = Console.ReadLine();
            }
        }
    }
}
