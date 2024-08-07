//---------------------------------------------------------------------
// Question 1: Player Class
// Create a class named "Player" to represent a character in a role-playing game.
// Include attributes for the player's name, level, health points (HP), and experience points (XP).
// Implement methods to level up the player, heal the player, and gain experience points.
// Hint: Declare a class with properties for name, level, HP, and XP. Implement methods to increase level, heal HP, and gain XP.
/* Think about how players progress in a typical RPG game. Consider what actions a player can take and how they affect the player's attributes. */

public class Player
{
    public string name { get; set; }
    public int level { get; set; }
    public int HP { get; set; }
    public int XP { get; set; }

    public int mana { get; set; }

    // Tao nhan vat

    public Player()
    {
        name = "no-name";
        level = 1;
        HP = 1000;
        XP = 0;
        mana = 100;
    }
    public Player(string _name)
    {
        name = _name;
        level = 1;
        HP = 1000;
        XP = 0;
        mana = 100;
    }

    // Tang cap
    public void LevelUp()
    {
        level++;
        HP += 200;
        Console.WriteLine($"{name} has leveled up to level {level}!");
    }

    // Nhan kinh nghiem

    public void GainXP(int amount)
    {
        XP += amount;

        if (XP >= 100)
        {
            LevelUp();
            XP -= 100;
        }
        Console.WriteLine($"{name} has gained {amount} point. Current XP is: {XP}");
    }

    // Hoi mau
    public void Healing(int amount)
    {
        HP += amount;
        Console.WriteLine($"{name} has been healing {amount} point. Current HP is: {HP}");
    }

}

//---------------------------------------------------------------------
// Question 2: Enemy Class
// Develop a class called "Enemy" to represent adversaries in a video game.
// Include properties for the enemy's name, health points (HP), attack power, and defense.
// Implement methods to calculate damage inflicted by the enemy and to update their HP.
// Hint: Define a class with attributes for name, HP, attack power, and defense. Create methods to calculate damage and update HP.
/* Consider the role enemies play in games. They typically attack players and can be defeated by reducing their HP to zero. */

class Enemy
{
    string name;
    int HP;
    int atkPower;
    int defense;

    public Enemy()
    {
        name = "Pawn";
        HP = 500;
        atkPower = 20;
        defense = 50;
    }

    public Enemy(string _name, int _HP, int _atkPower, int _defense)
    {
        name = _name;
        HP = _HP;
        atkPower = _atkPower;
        defense = _defense;
    }

    // Sat thuong gay ra boi "enemy"
    public void calculateDamage(int yourDefense)
    {

        int damagedCause = atkPower - yourDefense;

        if (damagedCause <= 0)
        {
            Console.WriteLine($"Enemy {name} cannot damage you!");
        }
        else
        {
            Console.WriteLine($"Enemy {name} deals you {damagedCause} damage!");

        }


    }

    // Tinh toan luong mau cua "emeny" sau khi nhan sat thuong

    public void takeDamaged(int yourAtk)
    {

        int damagedReceived = yourAtk - defense;
        if (damagedReceived <= 0)
        {

            damagedReceived = 0;
            Console.WriteLine($"Enemy {name} take no damage!!!");

        }

        HP -= damagedReceived;
        if (HP <= 0)
        {
            Console.WriteLine($"Enemy {name} is dead!!!");
        }
        Console.WriteLine($"Enemy {name} is received {damagedReceived} damage. Current HP is: {HP}");
    }
}

//---------------------------------------------------------------------
// Question 3: Potion Class
// Design a class named "Potion" to model health-restoring items in an adventure game.
// Include properties for the potion's name, healing power, and quantity in inventory.
// Implement a method to apply the potion to a player character and restore their health.
// Hint: Define a class with attributes for name, healing power, and quantity. Create a method to apply the potion and heal the player.
/* Think about how healing items function in games. They typically restore a portion of a player's health when consumed. */

public class Potion
{
    string potionName;
    int healingPower;
    int quantity;

    public Potion(string _name, int _healingPower, int _quantity)
    {
        potionName = _name;
        healingPower = _healingPower;
        quantity = _quantity;
    }

    public void UseOnPlayer(Player player)
    {
        if (quantity > 0)
        {
            player.Healing(healingPower);
            quantity--;
            Console.WriteLine($"{potionName} applied to {player.name}. {player.name} healing {healingPower} points. Remaining quantity: {quantity}. Current HP is: {player.HP}");
        }
        else
        {
            Console.WriteLine($"Item does not exist!");

        }
    }
}

//---------------------------------------------------------------------
// Question 4: Quest Class
// Create a class called "Quest" to represent tasks or missions in a quest-based game.
// Include properties for the quest's name, description, reward, and completion status.
// Implement methods to start the quest, complete the quest, and claim the reward.
// Hint: Define a class with attributes for name, description, reward, and completion status. Implement methods to manage quest progress.
/* Consider the structure of quests in games. They often involve objectives, rewards, and tracking completion status. */

class Quest
{
    string questName;
    string description;
    string reward;
    bool isCompleted;


    public Quest(string _questName, string _description, string _reward)
    {
        questName = _questName;
        description = _description;
        reward = _reward;
        isCompleted = false;
    }

    public void startQuest(Player player)
    {
        Console.WriteLine($"{player.name} join the {questName} quest!");
    }

    public void completedQuest(Player player)
    {
        isCompleted = true;
        Console.WriteLine($"{player.name} completed the {questName} quest!");
    }

    public void claimReward(Player player)
    {
        if (isCompleted)
        {
            Console.WriteLine($"{player.name} claim {reward}!");
        }
        else
        {
            Console.WriteLine($"{player.name}! Complete challenges before receiving rewards!");

        }
    }
}

//---------------------------------------------------------------------
// Question 5: Inventory Class
// Develop a class named "Inventory" to manage a player's items in a role-playing game.
// Include properties for the inventory's capacity, list of items, and methods to add/remove items.
// Implement functionality to check if an item exists in the inventory and display its details.
// Hint: Define a class with attributes for capacity and a list of items. Create methods to add, remove, and search for items.
/* Think about how inventories work in games. Players can store and manage various items they collect during their adventures. */


class Inventory
{
    int capacity;
    List<Item> items;

    public Inventory(int _capacity)
    {
        capacity = _capacity;
        items = new List<Item>();

    }

    public void AddItems(Item item)
    {

        if (items.Count < capacity)
        {

            items.Add(item);
            Console.WriteLine($"{item.name} added to inventory.");

        }
        else
        {
            Console.WriteLine($"Inventory is full! Cannot add items!");
        }

    }


    public void RemoveItems(Item item)
    {

        if (items.Contains(item))
        {
            items.Remove(item);
            Console.WriteLine($"{item.name} is removed.");

        }
        else
        {
            Console.WriteLine($"item was not found!");
        }
    }

    public bool detailsItems(Item item)
    {
        if (items.Contains(item))
        {

            Console.WriteLine($"Details: {item.name} - {item.type} -  {item.name}");

            return true;
        }
        else
        {

            Console.WriteLine($"This item was not found!");

            return false;
        }
    }
}

class Item
{
    public string name { get; set; }
    public string type { get; set; }
    public int value { get; set; }

    public Item(string _name, string _type, int _value)
    {
        name = _name;
        type = _type;
        value = _value;
    }
}

//---------------------------------------------------------------------
// Question 6: Spell Class
// Design a class called "Spell" to represent magical abilities or spells in a fantasy game.
// Include properties for the spell's name, damage, mana cost, and description.
// Implement methods to cast the spell, consume mana, and display spell details.
// Hint: Define a class with attributes for name, damage, mana cost, and description. Implement methods to cast and describe the spell.
/* Consider the mechanics of spellcasting in fantasy games. Spells often have different effects, costs, and descriptions. */

class Spell
{
    string name;
    int damage;
    int manaCost;
    string description;


    public Spell(string _name, int _damage, int _manaCost, string _description)
    {
        name = _name;
        damage = _damage;
        manaCost = _manaCost;
        description = _description;
    }

    public void castTheSpell(Player player)
    {
        if (player.mana >= manaCost)
        {
            Console.WriteLine($"{name} are being deployed!!!");
            player.mana -= manaCost;
        }
        else
        {
            Console.WriteLine("Not enough energy to cast");

        }
    }

    public void describeTheSpell()
    {

        Console.WriteLine($"Describe: name: {name}, damage: {damage}, mana cost: {manaCost}. {description}");

    }

}

public class Program
{
    public static void Main()
    {
        /*Player Class*/
        Player newBie = new Player();
        Player oldPlayer = new Player("PAK");

        newBie.GainXP(100);
        newBie.LevelUp();
        newBie.Healing(100);

        oldPlayer.GainXP(180);
        oldPlayer.LevelUp();
        oldPlayer.Healing(150);

        /*Potion Class*/
        // Potion medicine = new Potion("medicine", 500, 2);
        // medicine.UseOnPlayer(oldPlayer);
        // medicine.UseOnPlayer(oldPlayer);
        // medicine.UseOnPlayer(oldPlayer);

        /*Inventory*/
        // Inventory bag1 = new Inventory(3);
        // Item sword = new Item("Long sword", "Weapon", 250);
        // Item armor = new Item("Iron armor", "Weapon", 350);
        // Item potion = new Item("Potions", "Consume", 500);
        // Item kunai = new Item("Kunai", "Weapon", 250);


        // bag1.AddItems(sword);
        // bag1.AddItems(armor);
        // bag1.AddItems(potion);

        // bag1.detailsItems(sword);
        // bag1.detailsItems(armor);
        // bag1.detailsItems(potion);

        // bag1.AddItems(kunai);

        // bag1.RemoveItems(armor);
        // bag1.detailsItems(armor);

        /*Spell*/
        // Spell fireBang = new Spell("Fire Bang", 250, 80, "Extensive damage");
        // Spell pursue = new Spell("pursue", 250, 65, "Single target damage");

        // fireBang.castTheSpell(oldPlayer);
        // fireBang.describeTheSpell();
        // pursue.describeTheSpell();
        // pursue.castTheSpell(oldPlayer);


        /*Quest Class*/
        // Quest basic = new Quest("Pass the volcano", "Defeat the fire dragon at the western peak", "The long sword");
        // basic.startQuest(oldPlayer);
        // basic.completedQuest(oldPlayer);
        // basic.claimReward(oldPlayer);


        /*Enemy Class*/

        // Enemy soldier = new Enemy();
        // soldier.calculateDamage(100);
        // soldier.takeDamaged(100);

        // Enemy boss = new Enemy("Shadow Boss", 5000, 2500, 1500);
        // boss.calculateDamage(1000);
        // boss.takeDamaged(2000);
    }

}
