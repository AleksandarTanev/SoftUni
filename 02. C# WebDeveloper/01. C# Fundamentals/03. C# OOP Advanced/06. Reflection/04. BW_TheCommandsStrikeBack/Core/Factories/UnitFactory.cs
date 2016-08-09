namespace  _04.BW_TheCommandsStrikeBack.Core.Factories
{
    using System;
    using Contracts;
    using System.Linq;
    using System.Reflection;

    using Models.Units;

    public class UnitFactory : IUnitFactory
    {
        private Type[] typesOfUnites;

        public UnitFactory()
        {
            var typesInCurrentAssembly = Assembly.GetEntryAssembly().GetTypes();
            typesOfUnites = typesInCurrentAssembly
                .Where(t => t.IsClass)
                .Where(c => c.BaseType == typeof(Unit))
                .ToArray();
        }

        public IUnit CreateUnit(string unitType)
        {
            Type wantedUnit = this.typesOfUnites.FirstOrDefault(c => c.Name == unitType);
            var constructorUnitClass = wantedUnit?.GetConstructor(Type.EmptyTypes);
            IUnit objectUnit = (IUnit) constructorUnitClass?.Invoke(new object[0]);
            
            return objectUnit;
        }
    }
}
 