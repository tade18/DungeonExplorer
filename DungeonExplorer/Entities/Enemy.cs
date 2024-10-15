using System.Reflection.Metadata.Ecma335;

namespace DungeonExplorer;

public class Enemy
{
    public string EnemyName;
    public int EnemyBaseDamage;
    public int EnemyHp;

    public Enemy(string name, int baseDamage, int hp)
    {
        EnemyName = name;
        EnemyHp = hp;
        EnemyBaseDamage = baseDamage;
    }

    public static class EnemyFactory
    {
        public static Enemy CreateSkeleton()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---> There is a skeleton ready to fight!");
            Console.ResetColor();
            return new Enemy("Skeleton", 5, 35);
        }

        public static Enemy CreateZombie()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---> There is a zombie, looking really hungry!");
            Console.ResetColor();
            return new Enemy("Zombie", 3, 50);
        }

        public static Enemy CreateMirrorClone()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(
                "---> There is some kind of magical mirror! Stay aware, there is someone inside looking for a fight! ");
            Console.ResetColor();
            return new Enemy("Mirror Clone", 1, 10);
        }

        public static Enemy CreateLethalCactus()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---> Looks like someone left a cactus here! But really angry cactus!");
            Console.ResetColor();
            return new Enemy("Lethal Cactus", 7, 20);
        }

        public static Enemy CreateMedusa()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---> Cover your eyes. It is a Medusa!");
            Console.ResetColor();
            return new Enemy("Medusa", 8, 30);
        }

        public static Enemy CreateSpider()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---> Oh no! Spider!");
            Console.ResetColor();
            return new Enemy("Spider", 2, 28);
        }

        public static Enemy CreateDeadlyFog()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---> There is some kind of fog. But it has magic energy!");
            Console.ResetColor();
            return new Enemy("Deadly Fog", 1, 35);
        }

        public static Enemy CreateBoss()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                        \n@@@@@@@    @@@@@@    @@@@@@    @@@@@@   \n@@@@@@@@  @@@@@@@@  @@@@@@@   @@@@@@@   \n@@!  @@@  @@!  @@@  !@@       !@@       \n!@   @!@  !@!  @!@  !@!       !@!       \n@!@!@!@   @!@  !@!  !!@@!!    !!@@!!    \n!!!@!!!!  !@!  !!!   !!@!!!    !!@!!!   \n!!:  !!!  !!:  !!!       !:!       !:!  \n:!:  !:!  :!:  !:!      !:!       !:!   \n :: ::::  ::::: ::  :::: ::   :::: ::   \n:: : ::    : :  :   :: : :    :: : :   ");
            Console.WriteLine("It's a Dungeon Master!!!");
            Console.ResetColor();
            return new Enemy("DungeonMaster", 10, 45);
        }
    }

    public void TakeDamage(int damage)
    {
        EnemyHp -= damage;
    }

    public void Attack(Player player)
    {
        int damage = EnemyBaseDamage;
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"{EnemyName} -> attacks {player.Name} for {damage} damage!");
        Console.ResetColor();
        player.Health -= damage;
    }

    public void EnemyStatus()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"---{EnemyName}, {EnemyHp} hp, {EnemyBaseDamage} damage---");
        Console.ResetColor();
    }
    
}