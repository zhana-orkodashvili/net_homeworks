using System;

namespace homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm Zhana Orkodashvili");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor= ConsoleColor.White;
            Console.WriteLine("Enter your name:");
            Console.WriteLine(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine("Console color was reset.");
        }
    }
}
