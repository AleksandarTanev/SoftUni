namespace _08.Pokemon_Trainer
{

    using System.Collections.Generic;
    using System.Linq;

    public class Trainer
    {
        public string name;
        public int badges = 0;
        public List<Pokemon> pokemons;

        public Trainer(string name)
        {
            this.name = name;
            pokemons = new List<Pokemon>();
        }

        public void CheckElement(string element)
        {
            if (pokemons.Any(p => p.element == element))
            {
                badges++;
            }
            else
            {
                var toRemove = new List<int>();
                for (int i = 0; i < pokemons.Count; i++)
                {
                    pokemons[i].health -= 10;

                    if (pokemons[i].health <= 0)
                    {
                        toRemove.Add(i);
                    }
                }

                for (int i = toRemove.Count - 1; i >= 0; i--)
                {
                    pokemons.RemoveAt(toRemove[i]);
                }
            }
        }
    }
}
