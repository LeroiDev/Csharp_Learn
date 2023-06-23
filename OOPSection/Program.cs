using OOPSection_One;

internal class Program
{
    private static void Main(string[] args)
    {
        Rectangle lookABlock = new Rectangle();
        Console.WriteLine($"Initial height = {lookABlock.Height} and initial width = {lookABlock.Width}");

        lookABlock.Height = 10;
        lookABlock.Width = 5;
        Console.WriteLine($"First Block circumference = {lookABlock.CalculateCircumference()}");
        Console.WriteLine($"First Block are =  {lookABlock.CalculateArea()}");

        Rectangle anoterBlock = new Rectangle();
        anoterBlock.Height = 10;
        anoterBlock.Width = 2;
        Console.WriteLine($"Second Block circumference = {anoterBlock.CalculateCircumference()}");
        Console.WriteLine($"Second Block are =  {anoterBlock.CalculateArea()}");

    }
}