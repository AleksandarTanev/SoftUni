namespace _08.Pokemon_Trainer
{
    using System.Collections.Generic;
    using System.Linq;
    using System;

    public class Startup
    {
        public static void Main()
        {
            var trainers = new Dictionary<string, Trainer>();
            
            string input = Console.ReadLine();
            while (input != "Tournament")
            {
                var tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string trainerName = tokens[0];
                string pokemonName = tokens[1]; 
                string pokemonType = tokens[2]; 
                int pokemonHealth = int.Parse(tokens[3]);

                if (!trainers.ContainsKey(trainerName))
                {
                    trainers.Add(trainerName, new Trainer(trainerName));
                }
                trainers[trainerName].pokemons.Add(new Pokemon(pokemonName, pokemonType, pokemonHealth));

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "End")
            {
                foreach (var trainer in trainers)
                {
                    trainer.Value.CheckElement(input);
                }

                input = Console.ReadLine();
            }

            var output = trainers.OrderByDescending(t => t.Value.badges).Select(t => t.Key).ToList();

            foreach (var trainer in output)
            {
                Console.WriteLine($"{trainers[trainer].name} {trainers[trainer].badges} {trainers[trainer].pokemons.Count}");
            }
        }
    }
}
