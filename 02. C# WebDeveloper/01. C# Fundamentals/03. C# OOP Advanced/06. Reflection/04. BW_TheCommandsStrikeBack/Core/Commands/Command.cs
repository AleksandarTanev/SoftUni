﻿namespace _04.BW_TheCommandsStrikeBack.Core.Commands
{
    using Contracts;

    public abstract class Command : IExecutable
    {
        private string[] data;
        private IRepository repository;
        private IUnitFactory unitFactory;

        public Command(string[] data, IRepository repository, IUnitFactory unitFactory)
        {
            this.Data = data;
            this.Repository = repository;
            this.UnitFactory = unitFactory;
        }

        public string[] Data
        {
            get
            {
                return data;
            }

            private set
            {
                data = value;
            }
        }

        public IRepository Repository
        {
            get
            {
                return repository;
            }

            private set
            {
                repository = value;
            }
        }

        public IUnitFactory UnitFactory
        {
            get
            {
                return unitFactory;
            }

            private set
            {
                unitFactory = value;
            }
        }

        public abstract string Execute();
    }
}
