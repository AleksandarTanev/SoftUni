namespace _01.GenericBox
{
    using System;
    using Models;

    public class Startup
    {
        public static void Main()
        {
            var box1 = new Box<string>("life in a box");
            var box2 = new Box<int>(123123);

            Console.WriteLine(box1);
            Console.WriteLine(box2);
        }
    }
}
