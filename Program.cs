
class ElvenFighter
    {
        public string weapon;
        public double HP { get; set; }
        public double attack;
        public int karma;
        public int mana;
        public ElvenFighter(string weapon, double HP,double attack, int karma, int mana)
        {
            this.weapon = weapon;
            this.HP = HP;
            this.attack = attack;
            this.karma = karma;
            this.mana = mana;
        }
        public virtual void Attack()
        {
            Console.WriteLine("Elv attack!");
        }
        public virtual void Speak()
        {
            Console.WriteLine("Hello!");
        }
        public void ShowStats()
        {
            Console.WriteLine($"Weapon: {weapon}");
            Console.WriteLine($"HP: {HP}");
            Console.WriteLine($"Carma: {karma}");
            Console.WriteLine($"Mana: {mana}");
        }
    }
    class ElvenKnight : ElvenFighter
    {
        public ElvenKnight(string weapon, double HP, double attack, int karma, int magic) : base(weapon, HP, attack, karma, magic)
        {
        }
        public override void Attack()
        {
            Console.WriteLine("Elv Knight is attacking!");
        }
    }
    class ElvenScout : ElvenFighter
    {
        public ElvenScout(string weapon, double HP, double attack, int karma, int magic) : base(weapon, HP,attack, karma, magic)
        {
        }
        public override void Attack()
        {
            Console.WriteLine("Elv Scout is attacking!");
        }
    }
    class TempleKnight : ElvenKnight
    {
        public TempleKnight(string weapon, double HP, double attack, int karma, int magic) : base(weapon, HP,attack, karma, magic)
        {
        }
        public override void Attack()
        {
            Console.WriteLine("Temple Knight is attacking!");
        }
    }
    class GuasTemplar : TempleKnight
    {
        public GuasTemplar(string weapon, double HP, double attack, int karma, int magic) : base(weapon, HP, attack, karma, magic)
        {
        }
        public override void Attack()
        {
            Console.WriteLine("Guas Templar is attacking!");
        }
    }
    class SwordSinger : ElvenKnight 
    {
        public SwordSinger(string weapon, double HP, double attack, int karma, int magic) : base(weapon, HP, attack, karma, magic)
        {
        }
        public override void Attack()
        {
            Console.WriteLine("Sword Singer is attacking!");
        }
    }
    class SwordMuse : SwordSinger 
    {
        public SwordMuse(string weapon, double HP, double attack, int karma, int magic) : base(weapon, HP,attack, karma, magic)
        {
        }
        public override void Attack()
        {
            Console.WriteLine("Sword Muse is attacking!");
        }
    }
    class PlainsWalker : ElvenScout {
        public PlainsWalker(string weapon, double HP, double attack, int karma, int magic) : base(weapon, HP,attack, karma, magic)
        {
        }
        public override void Attack()
        {
            Console.WriteLine("Plains Walker is attacking!");
        }
    }
    class WindRider : PlainsWalker 
    {
        public WindRider(string weapon, double HP, double attack, int karma, int magic) : base(weapon, HP,attack, karma, magic)
        {
        }
        public override void Attack()
        {
            Console.WriteLine("windRider is attacking!");
        }
    }
    class SilverRanger : ElvenScout
    {
        public SilverRanger(string weapon, double HP, double attack, int karma, int magic) : base(weapon, HP, attack, karma, magic)
        {
        }
        public override void Attack()
        {
            Console.WriteLine("Silver Ranger is attacking!");
        }
    }
    class MoonLightSentinel : SilverRanger
    {
        public MoonLightSentinel(string weapon, double HP,double attack, int karma, int magic) : base(weapon, HP, attack, karma, magic)
        {
        }
        public override void Attack()
        {
            Console.WriteLine("MoonLightSentidel is attacking!");
        }
    }
class Enemy
{
    public string Name { get; set; }
    public string Weapon { get; set; }
    public double HP { get; set; }
    public int Karma { get; set; }
    public int mana { get; set; }
    public Enemy(string name, string weapon, double healthPercentage, int karma, int magic)
    {
        Name = name;
        Weapon = weapon;
        HP = healthPercentage;
        Karma = karma;
        mana = magic;
    }
    public void TakeDamage(int damage)
    {
        HP -= damage;
    }
}
namespace dz10_Heroes
{


    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите класс героя:");
            Console.WriteLine("1. Elven Knight");
            Console.WriteLine("2. Elven Scout");
            Console.WriteLine("3. Plains Walker");
            Console.WriteLine("4. Silver Ranger");
            Console.WriteLine("5. Wind Rider");
            Console.WriteLine("6. Moonlight Sentinel");
            Console.WriteLine("7. Temple Knight");
            Console.WriteLine("8. Sword Singer");
            Console.WriteLine("9. Guas Templar");
            Console.WriteLine("10. Sword Muse");
            int heroChoice = int.Parse(Console.ReadLine());
            ElvenFighter hero = CreateHero(heroChoice);
            Console.WriteLine($"You choose: {hero.GetType().Name}");
            Console.WriteLine($"HP: {hero.HP}");
            Console.WriteLine($"Carma: {hero.karma}");
            Console.WriteLine($"Mana: {hero.mana}");
            Console.WriteLine("Choose your enemy:");
            Console.WriteLine("1. Goblin");
            Console.WriteLine("2. Ork ");
            int enemyChoice = int.Parse(Console.ReadLine());
            Enemy enemy = null;
            switch (enemyChoice)
            {
                case 1:
                    enemy = new Enemy("Goblin", "Small Knight", 70, 0, 10);
                    break;
                case 2:
                    enemy = new Enemy("Ork", "Axe", 100, 0, 15);
                    break;
                default:
                    Console.WriteLine("Incorrect input.");
                    return;
            }
            Console.WriteLine($"You choose: {enemy.Name}");
            Console.WriteLine($"HP: {enemy.HP}");
            while (hero.HP > 0 && enemy.HP > 0)
            {
                Console.WriteLine("Press Enter for Attack...");
                Console.ReadLine();

                double damage = hero.attack; 
                Console.WriteLine($"{hero.GetType().Name} attacks {enemy.Name} and give  {damage} damage.");

                enemy.HP -= damage;
                Console.WriteLine($"HP {enemy.Name} after attack: {enemy.HP}");
            }

            Console.WriteLine("Fight ended.");
        }
        static ElvenFighter CreateHero(int choice)
        {
            switch (choice)
            {
                case 1:
                    return new ElvenKnight("Bid Sword", 100,80, 60, 20);
                case 2:
                    return new ElvenScout("Bow", 70, 120, 50, 50);
                case 3:
                    return new PlainsWalker("Small sword with crossbow", 90,79, 40, 35);
                case 4:
                    return new SilverRanger("Сrossbow", 90,130, 65, 55);
                case 5:
                    return new WindRider("Sword with crossbow", 105,105, 65, 50);
                case 6:
                    return new MoonLightSentinel("Magical Crossbow", 90, 145, 65, 60);
                case 7:
                    return new TempleKnight("Dual Sword", 95,85, 60, 30);
                case 8:
                    return new SwordSinger("Harp and Sword", 60, 65, 100, 70);
                case 9:
                    return new GuasTemplar("Dual Braid", 140, 120, 30, 40);
                case 10:
                    return new SwordMuse("legendary SwordHarp", 105,100, 60, 100);
                default:
                    throw new ArgumentException("Incorrect choise.");
            }
        }
    }  
}
