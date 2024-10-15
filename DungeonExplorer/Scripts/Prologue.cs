using System.Threading.Channels;

namespace DungeonExplorer;

public class Prologue
{
    public Prologue()
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        //cool ascii art that is not mine
        Console.WriteLine(
            "      _,.\t\t\t ______                                      _____           _                     \n    ,` -.)                       |  _  \\                                    |  ___|         | |                    \n   ( _/-\\\\-._                    | | | |_   _ _ __   __ _  ___  ___  _ __   | |____  ___ __ | | ___  _ __ ___ _ __ \n  /,|`--._,-^|            ,\t | | | | | | | '_ \\ / _` |/ _ \\/ _ \\| '_ \\  |  __\\ \\/ / '_ \\| |/ _ \\| '__/ _ \\ '__|\n  \\_| |`-._/||          ,'|\t | |/ /| |_| | | | | (_| |  __/ (_) | | | | | |___>  <| |_) | | (_) | | |  __/ |   \n    |  `-, / |         /  /      |___/  \\__,_|_| |_|\\__, |\\___|\\___/|_| |_| \\____/_/\\_\\ .__/|_|\\___/|_|  \\___|_|   \n    |     || |        /  /                           __/ |                            | |                          \n     `r-._||/   __   /  /                           |___/                             |_|                         \n __,-<_     )`-/  `./  /\n'  \\   `---'   \\   /  /\n    |           |./  /\n    /           //  /\n\\_/' \\         |/  /\n |    |   _,^-'/  /\n |    , ``  (\\/  /_\n  \\,.->._    \\X-=/^\n  (  /   `-._//^`\n   `Y-.____(__}\n    |     {__)\n          ()");

        //Just TEXT nothing more
        Console.WriteLine(
            " Welcome, brave adventurer! You stand at the entrance of a dangerous dungeon, where each room holds traps, monsters, and mysteries waiting to test your skills. " +
            "\n Hidden dangers lurk in every shadow, and only the clever and the bold will survive." +
            "\n Will you conquer the depths and claim the treasure, or fall victim to the perils that await?" +
            "\n Your journey begins now—your fate is in your hands.");
        Console.ResetColor();
    }
}