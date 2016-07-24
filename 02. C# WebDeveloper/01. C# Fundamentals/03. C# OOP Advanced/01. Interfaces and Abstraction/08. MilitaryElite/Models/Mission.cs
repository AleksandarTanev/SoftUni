﻿namespace _08.MilitaryElite.Models
{
    using Interfaces;
    using Enums;

    public class Mission : IMission
    {
        public Mission(string codeName, MissionState state)
        {
            this.CodeName = codeName;
            this.State = state;
        }

        public string CodeName { get; }
        public MissionState State { get; private set; }

        public void CompleteMission()
        {
            this.State = MissionState.Finished;
        }

        public override string ToString()
        {
            return $"  Code Name: {this.CodeName} State: {this.State}";
        }
    }
}
