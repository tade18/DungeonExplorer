namespace DungeonExplorer;

public class Treasure
{
    public void GenerateTreasure(Player player)
    {
        Console.WriteLine("You found a chest: ");
        Random RandomTreasure = new Random();
        int TreasureNum = RandomTreasure.Next(1, 12);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("         __________\n        /\\____;;___\\\n       | /         /\n       `. ())oo() .\n        |\\(%()*^^()^\\\n       %| |-%-------|\n      % \\ | %  ))   |\n      %  \\|%________|\nejm97  %%%%");
        switch (TreasureNum)
        {
            case 1:
                Console.WriteLine("You found a treasure: Normal Heal Potion");
                player.Heal(HealPotions.NormalHealPotion);
                break;
            case 2:
                Console.WriteLine("You found a treasure: Rare Heal Potion");
                player.Heal(HealPotions.RareHealPotion);
                break;
            case 3:
                Console.WriteLine("You found a treasure: Super-Rare Heal Potion");
                player.Heal(HealPotions.SuperRareHealPotion);
                break;
            case 4:
                Console.WriteLine("You found a treasure: Legendary Heal Potion");
                player.Heal(HealPotions.LegendaryHealPotion);
                break;
            case 5:
                Console.WriteLine("You found a treasure: Heal Potion of Near-Immortality");
                player.Heal(HealPotions.HealPotionOfNearImmortality);
                break;
            case 6:
                Console.WriteLine("You found a treasure: Weapon - Stick of truth");
                player.TakeWeapon(Weapons.StickOfTruth);
                break;
            case 7:
                Console.WriteLine("You found a treasure: Weapon - Sword of Sir Death");
                player.TakeWeapon(Weapons.SwordOfSirDead);
                break;
            case 8:
                Console.WriteLine("You found a treasure: Weapon - Sharp Stone of Mighty Geologist");
                player.TakeWeapon(Weapons.SharpStoneOfMightyGeologist);
                break;
            case 9:
                Console.WriteLine("You found a treasure: Weapon - Electric Wand of Wizard Panasonic");
                player.TakeWeapon(Weapons.ElectricWandOfWizardPanasonic);
                break;
            case 10:
                Console.WriteLine("You found a treasure: Weapon - Brutus Dagger");
                player.TakeWeapon(Weapons.BrutusDagger);
                break;
            case 11:
                Console.WriteLine("You found a treasure: Weapon - Apple of Eden");
                player.TakeWeapon(Weapons.AppleOfEden);
                break;
        }
        Console.ResetColor();
    }
}