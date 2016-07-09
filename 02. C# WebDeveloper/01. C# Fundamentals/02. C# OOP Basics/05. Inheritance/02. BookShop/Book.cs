namespace _02.BookShop
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Book
    {
        private const string InvalidAuthorNamePattern = @"^\d.*$";

        private string title;
        private string author;
        private double price;

        public Book(string author, string title, double price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }

                title = value;
            }
        }

        public string Author
        {
            get
            {
                return author;
            }

            set
            {
                string[] names = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (names.Length >= 2)
                {
                    if (names[1].Length > 0 && Regex.IsMatch(names[1], InvalidAuthorNamePattern))
                    {
                        throw new ArgumentException("Author not valid!");
                    }
                }

                author = value;
            }
        }

        public virtual double Price
        {
            get
            {
                return price;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }

                price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Type: ").Append(this.GetType().Name)
                    .Append(Environment.NewLine)
                    .Append("Title: ").Append(this.Title)
                    .Append(Environment.NewLine)
                    .Append("Author: ").Append(this.Author)
                    .Append(Environment.NewLine)
                    .Append("Price: ").Append($"{this.Price:F1}")
                    .Append(Environment.NewLine);

            return sb.ToString();
        }
    }
}
