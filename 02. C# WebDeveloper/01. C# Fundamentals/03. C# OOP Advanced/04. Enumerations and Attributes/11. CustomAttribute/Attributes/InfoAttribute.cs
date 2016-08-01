namespace _11.CustomAttribute.Attributes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    [AttributeUsage(AttributeTargets.Class)]
    public class InfoAttribute : Attribute
    {
        public string Author { get; set; }
        public int Revisions { get; set; }
        public string Description { get; set; }
        public string[] Reviewers { get; set; }
    }
}
