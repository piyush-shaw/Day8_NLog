using LoggerDemo;

internal class Program
{
    static void Main(string[] args)
    {
        AddNumbers obj = new AddNumbers();
        obj.Sum(2, 3);
        Console.WriteLine("This is a Logger Demo and Log generated successfully ");
        Console.ReadKey();
    }
}