namespace _08.MilitaryElite.Interfaces
{
    using System.Collections.Generic;

    public interface ILeutenantGeneral
    {
        HashSet<IPrivate> Privates { get; }

        void AddPrivate(IPrivate privatte);
    }
}
