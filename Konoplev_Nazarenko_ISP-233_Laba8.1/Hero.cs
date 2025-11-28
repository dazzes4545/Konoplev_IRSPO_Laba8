using static System.Net.Mime.MediaTypeNames;

class Hero
{
    public string Name { get; set; }
    public int Mana {  get; set; }
    public int Level { get; set; }
    private int _health;
    private int _maxHelth;

    public Hero(string name, int maxHelth) { 
        Name = name;
        Mana = 100;
        Level = 1;
        _maxHelth = maxHelth;
        _health = maxHelth;
    }

    public int Health {
        get => _health;
        set
        {
            if (value < 0) _health = 0;
            else if (value > _maxHelth) _health = _maxHelth;
            else _health = value;
        }
    }

    public string Status    //public string Status => (_health>0) ? "Жив": "Погиб"
    {
        get
        {
            if (_health > 0) return "Жив";
            else return "Погиб";
        }
    }
    public void TakeDamage(int damage)
    {
        if (_health <= 0)
        {
            Console.WriteLine("персонаж мертв");
            return;
        }
        Health -= damage;
        Console.WriteLine($"Персонаж {Name} получил {damage} урона. HP: {Health}. Статус: {Status}");
    }

    public void Heal(int amount)
    {
        if (_health <= 0)
        {
            Console.WriteLine("персонаж мертв");
            return;
        }

        Health += amount;
        Console.WriteLine($"Персонаж {Name} получил {amount} урона. HP: {Health}. Статус: {Status}");
    }

    

}
