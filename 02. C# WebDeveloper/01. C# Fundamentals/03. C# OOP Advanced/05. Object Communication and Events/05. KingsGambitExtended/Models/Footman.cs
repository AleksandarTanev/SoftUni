namespace _05.KingsGambitExtended.Models
{
    using System;

    using Interfaces;

    public class Footman : Person, IKillable
    {
        private King king;

        public Footman(string name, King king) 
            : base(name)
        {
            this.king = king;
            king.GetAttacked += KingGetAttacked;

            this.Hp = 2;
            this.IsAlive = true;
        }

        public bool IsAlive { get; private set; }
        public int Hp { get; private set; }

        private void KingGetAttacked(object sender, System.EventArgs e)
        {
            Console.WriteLine($"Footman {this.Name} is panicking!");
        }

        public void Kill()
        {
            this.Hp--;

            if (this.Hp == 0)
            {
                this.IsAlive = false;
                king.GetAttacked -= KingGetAttacked;
            }
        }
    }
}
