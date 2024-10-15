namespace DungeonExplorer;

public enum HealPotions
{
    NormalHealPotion = 3,
    RareHealPotion = 6,
    SuperRareHealPotion = 9,
    LegendaryHealPotion = 15,
    HealPotionOfNearImmortality = 30
}

public enum Weapons
{
    StickOfTruth = 8,
    SwordOfSirDead = 10,
    SharpStoneOfMightyGeologist = 12,
    ElectricWandOfWizardPanasonic = 14,
    AppleOfEden = 16,
    BrutusDagger = 18
}

public class Player
{
    public string Name;
    public int Health;
    public int BaseDamage;
    public int Score;
    public int AdditionalDamage;

    public Player(string name, int health)
    {
        Name = name;
        Health = health;
        BaseDamage = 7;
        Score = 0;
        AdditionalDamage = 0;
    }

    public void Heal(HealPotions healPotion)
    {
        Console.WriteLine($"Do you want to use {healPotion}?    (1=yes,2=no)");
        int healQ = Convert.ToInt32(Console.ReadLine());
        if (healQ == 1)
        {
            int healAmount = (int)healPotion;
            Health += healAmount;
            Console.WriteLine($"{Name} -> You used {healPotion}. Your current HP: {Health}");
        }
        else
        {
            Console.WriteLine("You haven't used anything.");
        }
    }

    public void TakeWeapon(Weapons weapon)
    {
        Console.WriteLine($"Do you want to take {weapon}? It has {(int)weapon} dmg    (1=yes,2=no)");
        int weaponQ = Convert.ToInt32(Console.ReadLine());
        if (weaponQ == 1)
        {
            BaseDamage = (int)weapon;
            Console.WriteLine($"{Name} -> You took weapon {weapon}. Your new Damage: {BaseDamage}");
        }
        else
        {
            Console.WriteLine("You haven't take it. You can't return for it later.");
        }
        
    }

    public void Attack(Enemy enemy)
    {
        int damage = BaseDamage;
        enemy.TakeDamage(damage);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"{Name} -> You attacked {enemy.EnemyName} for {damage} dmg.");
        Console.ResetColor();
    }

    public void PlayerStatus()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"---{Name}, {Health} hp, {BaseDamage} damage---");
        Console.ResetColor();
    }
}