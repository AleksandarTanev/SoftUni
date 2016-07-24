namespace _08.MilitaryElite.Models
{
    using System.Collections.Generic;
    using System.Text;

    using Interfaces;

    public class LeutenantGeneral : Private, ILeutenantGeneral
    {
        public LeutenantGeneral(string firstName, string lastName, string id, decimal salary) 
            : base(firstName, lastName, id, salary)
        {
            this.Privates = new HashSet<IPrivate>();
        }

        public HashSet<IPrivate> Privates { get; private set; }

        public void AddPrivate(IPrivate privatte)
        {
            this.Privates.Add(privatte);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append("\n" + "Privates:");

            foreach (var privatte in this.Privates)
            {
                sb.Append("\n" + "  " + privatte.ToString());
            }
            return sb.ToString();
        }
    }
}
