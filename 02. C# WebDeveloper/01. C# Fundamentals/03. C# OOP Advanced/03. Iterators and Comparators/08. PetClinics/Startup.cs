namespace _08.PetClinics
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Models;

    public class Startup
    {
        public static void Main()
        {
            var output = new StringBuilder();

            var clinics = new Dictionary<string, Clinic>();
            var pets = new Dictionary<string, Pet>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split();

                string command = tokens[0];

                switch (command)
                {
                    case "Create":
                        {
                            string type = tokens[1];

                            if (type == "Clinic")
                            {
                                string name = tokens[2];
                                int numRooms = int.Parse(tokens[3]);

                                try
                                {
                                    if (clinics.ContainsKey(name))
                                    {
                                        output.AppendLine("Invalid Operation!");
                                    }
                                    else
                                    {
                                        clinics.Add(name, new Clinic(name, numRooms));
                                    }
                                }
                                catch (ArgumentException ae)
                                {
                                    output.AppendLine("Invalid Operation!");
                                }
                            }
                            else if (type == "Pet")
                            {
                                string name = tokens[2];
                                int age = int.Parse(tokens[3]);
                                string kind = tokens[4];

                                if (pets.ContainsKey(name))
                                {
                                    output.AppendLine("Invalid Operation!");
                                }
                                else
                                {
                                    pets.Add(name, new Pet(name, age, kind));
                                }
                            }

                            break;
                        }

                    case "Add":
                        {
                            string petName = tokens[1];
                            string clinicName = tokens[2];

                            if (!pets.ContainsKey(petName) || !clinics.ContainsKey(clinicName))
                            {
                                output.AppendLine("Invalid Operation!");
                            }
                            else
                            {
                                bool isAdded = clinics[clinicName].AddPet(pets[petName]);
                                output.AppendLine(isAdded.ToString());
                            }

                            break;
                        }

                    case "Release":
                        {
                            string clinicName = tokens[1];

                            if (!clinics.ContainsKey(clinicName))
                            {
                                output.AppendLine("Invalid Operation!");
                            }
                            else
                            {
                                bool isRemoved = clinics[clinicName].ReleasePet();
                                output.AppendLine(isRemoved.ToString());
                            }

                            break;
                        }

                    case "HasEmptyRooms":
                        {

                            string clinicName = tokens[1];

                            if (!clinics.ContainsKey(clinicName))
                            {
                                output.AppendLine("Invalid Operation!");
                            }
                            else
                            {
                                bool hasEmptyRooms = clinics[clinicName].HasEmptyRooms();
                                output.AppendLine(hasEmptyRooms.ToString());
                            }

                            break;
                        }

                    case "Print":
                        {

                            string clinicName = tokens[1];

                            if (!clinics.ContainsKey(clinicName))
                            {
                                output.AppendLine("Invalid Operation!");
                                break;
                            }

                            if (tokens.Length == 2)
                            {
                                output.AppendLine(clinics[clinicName].ToString());
                            }
                            else
                            {
                                int room = int.Parse(tokens[2]) - 1;
                                output.AppendLine(clinics[clinicName][room].ToString());
                            }
                            break;
                        }
                }
            }
            
            Console.WriteLine(output);
        }
    }
}
