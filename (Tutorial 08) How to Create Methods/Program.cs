class Program
{
    static void Main(string[] args)
    {
        // A method is a block of code that we can use many times we want.
        Display("Mom");
        Display("Dad");
        
        int squareOf2 = SquareOfNumber(2);
        int squareOf3 = SquareOfNumber(3);
        int squareOf4 = SquareOfNumber(4);
        
        Console.WriteLine(squareOf2);
        Console.WriteLine(squareOf3);
        Console.WriteLine(squareOf4);
    }


    static void Display(string name)
    {
        Console.WriteLine($"Hi { name }!");
    }

    static int SquareOfNumber(int amount)
    {
        return amount * amount;
    }
}