﻿namespace _03.WildFarm.Animals
{
    using System;
    using Foods;

    public class Mouse : Mammal
    {
        public Mouse(string animalName, string animalType, double animalWeight, string livingRegion) : base(animalName, animalType, animalWeight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("SQUEEEAAAK!");
        }

        public override void Eat(Food food)
        {
            if (food is Vegetable)
            {
                Console.WriteLine("A cheese was just eaten!");
                this.FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine("Mouses are not eating that type of food!");
            }
        }
    }
}
