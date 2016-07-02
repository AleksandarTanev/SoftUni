namespace _05.AnimalClinic
{
    public class Animal
    {
        public int id;
        public string name;
        public string breed;

        public Animal(string name, string breed)
        {
            this.name = name;
            this.breed = breed;

            this.id = ++AnimalClinic.patientId;
        }

        public override string ToString()
        {
            return $"{this.name} {this.breed}";
        }
    }
}
