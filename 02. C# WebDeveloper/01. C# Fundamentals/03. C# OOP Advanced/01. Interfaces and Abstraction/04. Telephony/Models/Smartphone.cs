namespace _04.Telephony.Models
{
    using System;
    using System.Text.RegularExpressions;

    using Interfaces;

    public class Smartphone : ICallable, IWebBrowsable
    {
        public void Call(string number)
        {
            if (!Regex.IsMatch(number, @"^\d+$"))
            {
                Console.WriteLine("Invalid number!");
                return;
            }

            Console.WriteLine($"Calling... {number}");
        }

        public void Browse(string link)
        {
            if (Regex.IsMatch(link, @"\d"))
            {
                Console.WriteLine("Invalid URL!");
                return;
            }

            Console.WriteLine($"Browsing: {link}!");
        }
    }
}
