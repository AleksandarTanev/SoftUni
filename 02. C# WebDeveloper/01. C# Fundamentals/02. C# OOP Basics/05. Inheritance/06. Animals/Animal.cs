namespace _06.Animals
{
    using System;

    public class Animal : SoundProducible
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid input!");
                }

                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid input!");
                }

                age = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid input!");
                }

                if (value != "Male" && value != "Female")
                {
                    throw new ArgumentException("Invalid input!");
                }

                gender = value;
            }
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Not implemented!");
        }
    }
}
