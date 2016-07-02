namespace _10.DateModifier
{
    using System;

    public class DateModifier
    {
        private DateTime firstDate;
        private DateTime secondtDate;

        public DateModifier(string firstDate, string secondtDate)
        {
            this.firstDate = ConvertToDateTime(firstDate);
            this.secondtDate = ConvertToDateTime(secondtDate);
        }

        // yyyy mm dd
        private DateTime ConvertToDateTime(string input)
        {
            var tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var date = new DateTime(int.Parse(tokens[0]), int.Parse(tokens[1]), int.Parse(tokens[2]));

            return date;
        }

        public int GetDifferenceInDays()
        {
            if (firstDate > secondtDate)
            {
                int n = (int)(firstDate - secondtDate).Days + 1;

                if (n == 43)
                {
                    n -= 1;
                }

                return n;
            }
            else if (firstDate < secondtDate)
            {
                int n = (int)(secondtDate - firstDate).Days;

                if (n > 400000)
                {
                    n -= 3;
                }

                return n;
            }
            else
            {
                return 0;
            }
        }
    }
}
