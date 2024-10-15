namespace DungeonExplorer;

public class Epilogue
{
    public Epilogue(Player player)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("\n The darkness closes in as your strength fades. " +
                          "The perils of the dungeon were too great, and your adventure comes to an untimely end. The treasure remains hidden, the mysteries unsolved, and your tale... unfinished." +
                          "\n \n But fear not, brave soul. Perhaps next time, fate will be kinder.");
        Console.WriteLine(
            " _____ _                           _ \n|_   _| |                         | |\n  | | | |__   ___    ___ _ __   __| |\n  | | | '_ \\ / _ \\  / _ \\ '_ \\ / _` |\n  | | | | | |  __/ |  __/ | | | (_| |\n  \\_/ |_| |_|\\___|  \\___|_| |_|\\__,_|\n                                     ");
        Console.ResetColor();
        Console.WriteLine($"\nScore: {player.Score}");
    }
}