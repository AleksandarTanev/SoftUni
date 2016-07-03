namespace _05.CreatePizza
{
    using System;
    using System.Collections.Generic;

    public class Pizza
    {
        private string name;
        private Dough dough;

        private int numOfToppings;
        private List<Topping> toppings;

        public Pizza(string name, int numOfToppings)
        {
            this.Name = name;
            this.NumOfToppings = numOfToppings;

            this.toppings = new List<Topping>();
        }

        public string Name
        {
            get
            {
                return name;
            }

            private set
            {
                if (value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                name = value;
            }
        }

        public int NumOfToppings
        {
            get
            {
                return numOfToppings;
            }

            private set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }

                numOfToppings = value;
            }
        }

        public void SetDough(Dough dough)
        {
            if (this.dough == null)
            {
                this.dough = dough;
            }
        }

        public int GetToppingsCount()
        {
            return this.toppings.Count;
        }

        public double GetCalories()
        {
            double callories = 0;

            if (dough != null)
            {
                callories += dough.GetCalories();
            }

            foreach (var topping in toppings)
            {
                callories += topping.GetCalories();
            }

            return callories;
        }

        public void AddNewTopping(Topping topping)
        {
            if (this.toppings.Count < NumOfToppings)
            {
                this.toppings.Add(topping);
            }
            else
            {
                throw new ArgumentException("Cannot add more toppings.");
            }
        }
    }
}
