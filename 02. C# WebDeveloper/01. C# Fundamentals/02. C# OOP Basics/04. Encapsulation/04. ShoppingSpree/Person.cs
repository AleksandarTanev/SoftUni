namespace _04.ShoppingSpree
{
    using System;
    using System.Collections.Generic;

    public class Person
    {
        private string name;
        private double money;
        private List<Product> bag;

        public Person(string name, double money)
        {
            this.Name = name;
            this.Money = money;
            this.bag = new List<Product>();
        }

        public List<Product> Bag => this.bag;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException($"{nameof(Name)} cannot be empty");
                }

                name = value;
            }
        }

        public double Money
        {
            get
            {
                return money;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"{nameof(Money)} cannot be negative");
                }

                money = value;
            }
        }

        public void AddProductToBag(Product product)
        {
            if (product.Money > this.Money)
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
            else
            {
                Console.WriteLine($"{this.Name} bought {product.Name}");
                this.Money -= product.Money;
                this.bag.Add(product);
            }
        }
    }
}
