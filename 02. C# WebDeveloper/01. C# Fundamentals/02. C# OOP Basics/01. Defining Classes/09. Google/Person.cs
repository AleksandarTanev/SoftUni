namespace _09.Google
{
    using System.Collections.Generic;

    public class Person
    {
        public string name;
        public Company company;
        public List<Pokemon> pokemons;
        public List<Parent> parents;
        public List<Child> children;
        public Car car;

        public Person(string name)
        {
            this.name = name;
            this.pokemons = new List<Pokemon>();
            this.parents = new List<Parent>();
            this.children = new List<Child>();
        }

        public override string ToString()
        {
            string output = string.Empty;

            output += this.name + "\n";

            output += $"Company:\n";
            if (this.company != null)
            {
                output += $"{this.company.name} {this.company.department} {this.company.salary:F2}\n";
            }

            output += $"Car:\n";
            if (this.car != null)
            {
                output += $"{this.car.model} {this.car.speed}\n";
            }

            output += $"Pokemon:\n";
            if (this.pokemons.Count != 0)
            {
                foreach (var pokemon in pokemons)
                {
                    output += $"{pokemon.name} {pokemon.type}\n";
                }
            }

            output += $"Parents:\n";
            if (this.parents.Count != 0)
            {
                foreach (var parent in parents)
                {
                    output += $"{parent.name} {parent.birthday}\n";
                }
            }

            output += $"Children:";
            if (this.children.Count != 0)
            {
                foreach (var child in children)
                {
                    output += $"\n{child.name} {child.birthday}";
                }
            }

            return output;
        }
    }
}
