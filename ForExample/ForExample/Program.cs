using static System.Console;

namespace ForExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Type your first name and press ENTER: ");
            string firstName = ReadLine();
            Write("Type your age and press ENTER: ");
            string age = ReadLine();
            Write($"Hello {firstName}, you look good for {age}.");
            ReadKey();
        }
    }
}
