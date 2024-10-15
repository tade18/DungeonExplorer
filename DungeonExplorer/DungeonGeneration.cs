namespace DungeonExplorer;

public class Room
{
    public static bool hasChest;

    public Room()
    {
    }

    public void EnterRoom(Player player)
    {
        if (player.Health > 0)
        {
            Random rand = new Random();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n !You entered next room!");
            Console.ResetColor();
            {
                int enemyGenerator = rand.Next(1, 16);
                switch (enemyGenerator)
                {
                    case 1 or 2:
                        Fight fightSkelly = new Fight(player, Enemy.EnemyFactory.CreateSkeleton());
                        break;
                    case 3 or 4:
                        Fight fightZombie = new Fight(player, Enemy.EnemyFactory.CreateZombie());
                        break;
                    case 5 or 6:
                        Fight fightMirrorClone = new Fight(player, Enemy.EnemyFactory.CreateMirrorClone());
                        break;
                    case 7 or 8:
                        Fight fightLethalCactus = new Fight(player, Enemy.EnemyFactory.CreateLethalCactus());
                        break;
                    case 9 or 10:
                        Fight fightMedusa = new Fight(player, Enemy.EnemyFactory.CreateMedusa());
                        break;
                    case 11 or 12:
                        Fight fightSpider = new Fight(player, Enemy.EnemyFactory.CreateSpider());
                        break;
                    case 13 or 14:
                        Fight fightDeadlyFog = new Fight(player, Enemy.EnemyFactory.CreateDeadlyFog());
                        break;
                    case 15:
                        Fight fightBossFight = new Fight(player, Enemy.EnemyFactory.CreateBoss());
                        break;
                }
            }
        }
    }
}