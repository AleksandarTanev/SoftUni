namespace _10.FamilyTree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Startup
    {
        public static void Main()
        {
            var people = new List<Person>();

            //Regex ptnNameOnly = new Regex(@"^(?<name>\w+ \w+)$");

            //Regex ptnBirthdayOnly = new Regex(@"^(?<birthday>\d+\/\d+\/\d+)$");

            Regex ptnNameWithBirthday = new Regex(@"^(?<name>\w+ \w+) (?<birthday>\d+\/\d+\/\d+)$");

            Regex ptnName_Name = new Regex(@"^(?<name_1>\w+ \w+) - (?<name_2>\w+ \w+)$");

            Regex ptnBirthday_Birthday = new Regex(@"^(?<birthday_1>\d+\/\d+\/\d+) - (?<birthday_2>\d+\/\d+\/\d+)$");

            Regex ptnName_Birthday = new Regex(@"^(?<name>\w+ \w+) - (?<birthday>\d+\/\d+\/\d+)$");

            Regex ptnBirthday_Name = new Regex(@"^(?<birthday>\d+\/\d+\/\d+) - (?<name>\w+ \w+)$");

            string nameToSearch = string.Empty;
            string birthdayToSearch = string.Empty;

            string input = Console.ReadLine();

            if (input.Contains("/"))
            {
                birthdayToSearch = input;
            }
            else
            {
                nameToSearch = input;
            }

            input = Console.ReadLine();
            while (input != "End")
            {
                if (ptnNameWithBirthday.IsMatch(input))
                {
                    Match match = ptnNameWithBirthday.Match(input);

                    string givenName = match.Groups["name"].ToString();
                    string givenBirthday = match.Groups["birthday"].ToString();

                    bool nameFound = false;
                    bool birthdayFound = false;

                    if (people.Any(p => p.name == givenName))
                    {
                        nameFound = true;
                    }

                    if (people.Any(p => p.birthday == givenBirthday))
                    {
                        birthdayFound = true;
                    }

                    if (!nameFound && !birthdayFound)
                    {
                        people.Add(new Person() { name = givenName, birthday = givenBirthday });
                    }
                    else if (nameFound && !birthdayFound)
                    {
                        Person foundPerson = people.FirstOrDefault(p => p.name == givenName);
                        foundPerson.birthday = givenBirthday;
                    }
                    else if (!nameFound && birthdayFound)
                    {
                        Person foundPerson = people.FirstOrDefault(p => p.birthday == givenBirthday);
                        foundPerson.name = givenName;
                    }
                    else if (nameFound && birthdayFound)
                    {
                        Person foundNamePerson = people.FirstOrDefault(p => p.name == givenName);
                        Person foundBirthdayPerson = people.FirstOrDefault(p => p.birthday == givenBirthday);

                        int indexFoundNamePerson = people.IndexOf(foundNamePerson);

                        people.RemoveAt(indexFoundNamePerson);

                        int indexFoundBirthdayPerson = people.IndexOf(foundBirthdayPerson);

                        people.RemoveAt(indexFoundBirthdayPerson);

                        string newName = foundNamePerson.name;
                        string newBirthday = foundBirthdayPerson.birthday;
                        List<Person> newParents = foundNamePerson.parents.Union(foundBirthdayPerson.parents).ToList();
                        List<Person> newChildren = foundNamePerson.children.Union(foundBirthdayPerson.children).ToList();

                        Person newPerson = new Person()
                        {
                            name = newName,
                            birthday = newBirthday,
                            parents = newParents,
                            children = newChildren
                        };

                        foreach (var person in people)
                        {
                            for (int i = 0; i < person.parents.Count; i++)
                            {
                                if (person.parents[i] == foundNamePerson || person.parents[i] == foundBirthdayPerson)
                                {
                                    person.parents[i] = newPerson;
                                }
                            }

                            for (int i = 0; i < person.children.Count; i++)
                            {
                                if (person.children[i] == foundNamePerson || person.children[i] == foundBirthdayPerson)
                                {
                                    person.children[i] = newPerson;
                                }
                            }
                        }

                        people.Add(newPerson);
                    }
                }
                else if (ptnName_Name.IsMatch(input))
                {
                    Match match = ptnName_Name.Match(input);

                    string givenParentName = match.Groups["name_1"].ToString();
                    string givenChildtName = match.Groups["name_2"].ToString();

                    Person parent;
                    Person child;

                    if (people.Any(p => p.name == givenParentName))
                    {
                        parent = people.FirstOrDefault(p => p.name == givenParentName);
                    }
                    else
                    {
                        parent = new Person() { name = givenParentName };
                        people.Add(parent);
                    }

                    if (people.Any(p => p.name == givenChildtName))
                    {
                        child = people.FirstOrDefault(p => p.name == givenChildtName);
                    }
                    else
                    {
                        child = new Person() { name = givenChildtName };
                        people.Add(child);
                    }

                    parent.children.Add(child);
                    child.parents.Add(parent);
                }
                else if (ptnBirthday_Birthday.IsMatch(input))
                {
                    Match match = ptnBirthday_Birthday.Match(input);

                    string givenParentBirthday = match.Groups["birthday_1"].ToString();
                    string givenChildtBirthday = match.Groups["birthday_2"].ToString();

                    Person parent;
                    Person child;

                    if (people.Any(p => p.birthday == givenParentBirthday))
                    {
                        parent = people.FirstOrDefault(p => p.birthday == givenParentBirthday);
                    }
                    else
                    {
                        parent = new Person() { birthday = givenParentBirthday };
                        people.Add(parent);
                    }

                    if (people.Any(p => p.birthday == givenChildtBirthday))
                    {
                        child = people.FirstOrDefault(p => p.birthday == givenChildtBirthday);
                    }
                    else
                    {
                        child = new Person() { birthday = givenChildtBirthday };
                        people.Add(child);
                    }

                    parent.children.Add(child);
                    child.parents.Add(parent);
                }
                else if (ptnName_Birthday.IsMatch(input))
                {
                    Match match = ptnName_Birthday.Match(input);

                    string givenParentName = match.Groups["name"].ToString();
                    string givenChildtBirthday = match.Groups["birthday"].ToString();

                    Person parent;
                    Person child;

                    if (people.Any(p => p.name == givenParentName))
                    {
                        parent = people.FirstOrDefault(p => p.name == givenParentName);
                    }
                    else
                    {
                        parent = new Person() { name = givenParentName };
                        people.Add(parent);
                    }

                    if (people.Any(p => p.birthday == givenChildtBirthday))
                    {
                        child = people.FirstOrDefault(p => p.birthday == givenChildtBirthday);
                    }
                    else
                    {
                        child = new Person() { birthday = givenChildtBirthday };
                        people.Add(child);
                    }

                    parent.children.Add(child);
                    child.parents.Add(parent);
                }
                else if (ptnBirthday_Name.IsMatch(input))
                {
                    Match match = ptnBirthday_Name.Match(input);

                    string givenParentBirthday = match.Groups["birthday"].ToString();
                    string givenChildtName = match.Groups["name"].ToString();

                    Person parent;
                    Person child;

                    if (people.Any(p => p.birthday == givenParentBirthday))
                    {
                        parent = people.FirstOrDefault(p => p.birthday == givenParentBirthday);
                    }
                    else
                    {
                        parent = new Person() { birthday = givenParentBirthday };
                        people.Add(parent);
                    }

                    if (people.Any(p => p.name == givenChildtName))
                    {
                        child = people.FirstOrDefault(p => p.name == givenChildtName);
                    }
                    else
                    {
                        child = new Person() { name = givenChildtName };
                        people.Add(child);
                    }

                    parent.children.Add(child);
                    child.parents.Add(parent);
                }

                input = Console.ReadLine();
            }

            if (nameToSearch != string.Empty)
            {
                Person outputPerson = people.FirstOrDefault(p => p.name == nameToSearch);
                Console.WriteLine(outputPerson);
            }
            else
            {
                Person outputPerson = people.FirstOrDefault(p => p.birthday == birthdayToSearch);
                Console.WriteLine(outputPerson);
            }
        }
    }
}
