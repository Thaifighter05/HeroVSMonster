 class Monster : Character
    {
        public Monster(string name, int health) : base(name, health) { }

        public void FerociousAttack(Character target)
        {
            Console.WriteLine($"{Name} attackerar våldsamt {target.Name}!");
            target.Health -= 12;
        }
    }