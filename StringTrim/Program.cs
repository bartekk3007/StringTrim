namespace StringTrim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "  Bartek ";
            string improvedText = text.Trim(' ');
            Console.WriteLine(improvedText);
        }
    }
}
