namespace _06.MirrorImage.Models
{
    using System;
    using System.Collections.Generic;

    public class Wizzard
    {
        public static int wizardsIDs = 0;
        public static List<Wizzard> allWizards = new List<Wizzard>(); 

        private int id;
        private string name;
        private int magicPower;

        private Wizzard firstWizzardCopy;
        private Wizzard secondWizzardCopy;

        public Wizzard(string name, int magicPower)
        {
            this.Id = Wizzard.wizardsIDs;
            this.Name = name;
            this.MagicPower = magicPower;

            Wizzard.wizardsIDs++;
            allWizards.Add(this);
        }

        public int Id
        {
            get
            {
                return id;
            }

            private set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            private set
            {
                name = value;
            }
        }

        public int MagicPower
        {
            get
            {
                return magicPower;
            }

            private set
            {
                magicPower = value;
            }
        }

        public void CastReflection()
        {
            Console.WriteLine($"{this.Name} {this.Id} casts Reflection");

            this.firstWizzardCopy?.CastReflection();
            this.secondWizzardCopy?.CastReflection();

            if (this.firstWizzardCopy == null)
            {
                this.firstWizzardCopy = new Wizzard(this.Name, this.MagicPower / 2);
            }

            if (this.secondWizzardCopy == null)
            {
                this.secondWizzardCopy = new Wizzard(this.Name, this.MagicPower / 2);
            }
        }

        public void CastFireBall()
        {
            Console.WriteLine($"{this.Name} {this.Id} casts Fireball for {this.MagicPower} damage");

            this.firstWizzardCopy?.CastFireBall();
            this.secondWizzardCopy?.CastFireBall();
        }
    }
}
