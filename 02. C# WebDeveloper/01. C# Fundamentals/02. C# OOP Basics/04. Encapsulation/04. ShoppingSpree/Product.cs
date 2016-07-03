namespace _04.ShoppingSpree
{
    using System;

    public class Product
    {
        private string name;
        private double money;

        public Product(string name, double money)
        {
            this.Name = name;
            this.Money = money;
        }

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

        public override string ToString()
        {
            return this.Name;
        }
    }
}
