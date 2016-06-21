namespace _11.SemanticHTML
{
    using System;
    using System.Text.RegularExpressions;

    public class Startup
    {
        public static void Main()
        {
            Regex firstPattern = new Regex(@"^(?<begOfLine>\s*)<div(?<firstPart>.*?)(id|class)\s*=\s*.(?<tag>\w+).(?<secondPart>.*?)>");
            Regex secondPattern = new Regex(@"<\/div>\s*<\s*!\s*--\s*(?<tag>\w*)\s*--\s*>");
            Regex begOfLinePattern = new Regex(@"^\s*");

            string input = Console.ReadLine();
            while (input != "END")
            {
                if (input.Contains("div"))
                {
                    string begOfLine = begOfLinePattern.Match(input).ToString();

                    string output = firstPattern.Replace(input, "<${tag} ${firstPart} ${secondPart}>");
                    output = secondPattern.Replace(output, "</${tag}>");

                    output = Regex.Replace(output, " +", " ");
                    output = Regex.Replace(output, @"\s*>", ">");
                    Console.WriteLine(begOfLine + output.Trim());
                }
                else
                {
                    Console.WriteLine(input);
                }

                input = Console.ReadLine();
            }
        }
    }
}
