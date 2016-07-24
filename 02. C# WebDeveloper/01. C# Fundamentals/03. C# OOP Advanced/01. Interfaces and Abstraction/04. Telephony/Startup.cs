namespace _04.Telephony
{
    using System;
    using Models;

    public class Startup
    {
        public static void Main()
        {
            var phone = new Smartphone();

            var numbers = Console.ReadLine().Split(new char[] {' '});
            var websites = Console.ReadLine().Split(new char[] {' '});

            foreach (var number in numbers)
            {
                phone.Call(number);
            }

            foreach (var website in websites)
            {
                phone.Browse(website);
            }
        }
    }
}