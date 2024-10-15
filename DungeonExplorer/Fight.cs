using System.Net;

namespace DungeonExplorer;

public class Fight
{
    private Player _player;
    private Enemy _enemy;

    public Fight(Player player, Enemy enemy)
    {
        _player = player;
        _enemy = enemy;

        Console.WriteLine("Do you want to fight it? (y/n)   ..or try to find another way..");
        char UserChoiceFight = Console.ReadLine().ToUpper()[0];
        if (UserChoiceFight == 'Y')
        {
            while (_player.Health > 0 && _enemy.EnemyHp > 0)
            {
                _player.Attack(_enemy);
                if (_enemy.EnemyHp <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{_enemy.EnemyName} HAS BEEN DEFEATED!");
                    Console.ResetColor();
                    _player.Score++;
                    Random randA = new Random();
                    int randAInt = randA.Next(0, 100);
                    // 40% treasure chance
                    if (randAInt < 40)
                    {
                        Treasure chest = new Treasure();
                        chest.GenerateTreasure(_player);
                    }

                    break;
                }

                _enemy.Attack(_player);
                if (_player.Health <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($"{_player.Name} HAS BEEN DEFEATED!");
                    Console.ResetColor();
                    Epilogue epilogue = new Epilogue(player);
                    break;
                }

                if (_enemy.EnemyName == "DungeonMaster")
                {
                    _enemy.Attack(_player);
                }

                if (_player.Health <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($"{_player.Name} HAS BEEN DEFEATED!");
                    Console.ResetColor();
                    Epilogue epilogue = new Epilogue(player);
                    break;
                }

                _player.PlayerStatus();
                _enemy.EnemyStatus();
                Console.WriteLine("\n--- Next Round ---\n");
            }
        }
        else if (UserChoiceFight != 'Y')
        {
            Epilogue epilogue = new Epilogue(player);
            _player.Health = 0;
        }
    }
}