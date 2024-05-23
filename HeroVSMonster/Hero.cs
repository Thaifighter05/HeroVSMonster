 class Hero : Character
    {
        public Hero(string name, int health) : base(name, health) { }

        public void HeroicAttack(Character target)
        {
            Console.WriteLine($"{Name} attackerar heroiskt {target.Name}!");
            target.Health -= 15;
        }
         public void Heal()
        {
            Console.WriteLine($"{Name} läker!");
            Health += 10;
        }
    }

    