 class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public Character(string name, int health)
        {
            Name = name;
            Health = health;
        }
         public void BasicAttack(Character target)
        {
            Console.WriteLine($"{Name} attackerar {target.Name}!");
            target.Health -= 10;
        }
    
    }
    