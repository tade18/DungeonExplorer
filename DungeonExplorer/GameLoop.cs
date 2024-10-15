namespace DungeonExplorer;

public class GameLoop
{
    public GameLoop(Player player)
    {
        Random roomRand = new Random();
        while (player.Health > 0)
        {
            Console.WriteLine("What´s your next step?");
            Console.WriteLine("\n 1 = Go to next room, 2 = Run away, 3 = Player Status");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            if (userChoice == 1)
            {
                Room room = new Room();
                room.EnterRoom(player);
            }

            if (userChoice == 2)
            {
                Epilogue epilogue = new Epilogue(player);
                player.Health = 0;
            }

            if (userChoice == 3)
            {
                player.PlayerStatus();
            }
        }
    }
}