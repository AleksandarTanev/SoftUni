namespace _08.MilitaryElite.Factories
{
    using System;
    using System.ComponentModel;
    using System.Linq;

    using Enums;
    using Interfaces;
    using Models;

    public static class SoldierFactory
    {
        public static ISoldier GenerateSoldier(string[] tokens)
        {
            string type = tokens[0];

            string id = tokens[1];
            string fname = tokens[2];
            string lname = tokens[3];

            switch (type)
            {
                case "Private":
                    {
                        decimal salary = decimal.Parse(tokens[4]);
                        Private newPrivate = new Private(fname, lname, id, salary);

                        return newPrivate;
                    }

                case "Spy":
                    {
                        long codeNumber = long.Parse(tokens[4]);
                        Spy newSpy = new Spy(fname, lname, id, codeNumber);

                        return newSpy;
                    }

                case "LeutenantGeneral":
                    {
                        decimal salary = decimal.Parse(tokens[4]);

                        var newLeutenantGeneral = new LeutenantGeneral(fname, lname, id, salary);

                        for (int i = 5; i < tokens.Length; i++)
                        {
                            string idToAdd = tokens[i];
                            var foundSoldier = Private.privates.FirstOrDefault(s => s.Id == idToAdd);

                            if (foundSoldier != null)
                            {
                                newLeutenantGeneral.AddPrivate(foundSoldier);
                            }
                        }

                        return newLeutenantGeneral;
                    }

                case "Engineer":
                    {
                        decimal salary = decimal.Parse(tokens[4]);

                        Corp corps;
                        if (!Enum.TryParse<Corp>(tokens[5], out corps))
                        {
                            throw new InvalidEnumArgumentException();
                        }

                        var newEngineer = new Engineer(fname, lname, id, salary, corps);

                        for (int i = 6; i < tokens.Length; i += 2)
                        {
                            string repairPart = tokens[i];
                            int repairHours = int.Parse(tokens[i + 1]);

                            newEngineer.AddRepair(new Repair(repairPart, repairHours));
                        }

                        return newEngineer;
                    }

                case "Commando":
                    {
                        decimal salary = decimal.Parse(tokens[4]);

                        Corp corps;
                        if (!Enum.TryParse<Corp>(tokens[5], out corps))
                        {
                            throw new InvalidEnumArgumentException();
                        }

                        var newCommando = new Commando(fname, lname, id, salary, corps);

                        for (int i = 6; i < tokens.Length; i += 2)
                        {
                            string missionName = tokens[i];

                            MissionState missionState;
                            if (!Enum.TryParse<MissionState>(tokens[i + 1], out missionState))
                            {
                                continue;
                            }

                            newCommando.AddMission(new Mission(missionName, missionState));
                        }

                        return newCommando;
                    }
            }

            return null;
        }
    }
}
