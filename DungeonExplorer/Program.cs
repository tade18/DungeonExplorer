using System;

namespace DungeonExplorer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert your name:");
            string userName;
            userName = Console.ReadLine();
            Player player = new Player(userName, 100);
            Prologue prologue = new Prologue();
            GameLoop gameLoop = new GameLoop(player);

            Console.ReadLine();
        }
    }
}