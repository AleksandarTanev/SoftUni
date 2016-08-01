namespace _02.KingsGambit.Models
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

            this.IsAlive = true;
        }

        public bool IsAlive { get; }

        private void KingGetAttacked(object sender, System.EventArgs e)
        {
            Console.WriteLine($"Footman {this.Name} is panicking!");
        }

        public void Kill()
        {
            king.GetAttacked -= KingGetAttacked;
        }
    }
}
