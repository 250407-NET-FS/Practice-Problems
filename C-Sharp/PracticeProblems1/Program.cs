// ---------------------------------------------
// PROGRAM LAUNCHER
// File: Program.cs
// Purpose: Entry point to launch a selected exercise
// ---------------------------------------------

namespace Refresher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== C# Refresher Launcher ==\n");

            // Uncomment the exercise you want to run and comment out the others:

            Exercise01.Run();
            Exercise02.Run();
            // Exercise03.Run();
            // Exercise04.Run();
            // Exercise05.Run();
            // Exercise06.Run();
            // Exercise07.Run();
            // Exercise08.Run();

            Console.WriteLine("\n>> To run an exercise, uncomment its method call above.");
        }
    }
}
