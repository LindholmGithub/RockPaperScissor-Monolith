// See https://aka.ms/new-console-template for more information

using Monolith;
using Serilog;

public class Program
{
    public static void Main()
    {
        var game = new Game();
        for (int i = 0; i < 100; i++)
        {
            game.Start();
        }
        Console.WriteLine("Finished");
        Log.CloseAndFlush();
    }
}