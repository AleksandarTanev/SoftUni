namespace _09.TrafficLights
{
    using System;
    using System.Linq;

    using Enums;
    using Models;

    public class Startup
    {
        public static void Main()
        {
            var givenLights = Console.ReadLine().Split();
            var trafficLights = givenLights
                    .Select(l => new TrafficLight((LightState) Enum.Parse(typeof (LightState), l)))
                    .ToList();

            Action changeLightForAllTrafficLights = null;
            foreach (var trafficLight in trafficLights)
            {
                if (changeLightForAllTrafficLights == null)
                {
                    changeLightForAllTrafficLights = trafficLight.ChangeToNextLight;
                }
                else
                {
                    changeLightForAllTrafficLights += trafficLight.ChangeToNextLight;
                }
            }

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

                changeLightForAllTrafficLights?.Invoke();

                Console.WriteLine(string.Join(" ", trafficLights));
            }
        }
    }
}
