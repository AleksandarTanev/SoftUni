namespace _06.ValidatEPizza
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var teams = new Dictionary<string, Team>();

            string input = Console.ReadLine();
            while (input != "END")
            {
                try
                {
                    var tokens = input.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                    string inputType = tokens[0];

                    if (inputType == "Team")
                    {
                        string teamName = tokens[1];
                        if (!teams.ContainsKey(teamName))
                        {
                            teams.Add(teamName, new Team(teamName));
                        }
                    }
                    else if (inputType == "Add")
                    {
                        string teamName = tokens[1];
                        string playerName = tokens[2];
                        int endurance = int.Parse(tokens[3]);
                        int sprint = int.Parse(tokens[4]);
                        int dribble = int.Parse(tokens[5]);
                        int passing = int.Parse(tokens[6]);
                        int shooting = int.Parse(tokens[7]);

                        if (teams.ContainsKey(teamName))
                        {
                            teams[teamName].AddPlayer(new Player(playerName, endurance, sprint, dribble, passing, shooting));
                        }
                        else
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                        }
                    }
                    else if (inputType == "Remove")
                    {
                        string teamName = tokens[1];
                        string playerName = tokens[2];

                        if (teams.ContainsKey(teamName))
                        {
                            teams[teamName].RemovePlayer(playerName);
                        }
                        else
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                        }
                    }
                    else if (inputType == "Rating")
                    {
                        string teamName = tokens[1];

                        if (teams.ContainsKey(teamName))
                        {
                            Console.WriteLine(teams[teamName]);
                        }
                        else
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                

                input = Console.ReadLine();
            }
        }
    }
}
