
    class Character
    {
        public string Name { get; set; } // Namnet på karaktären
        public int Health { get; set; } // HP för karaktären

        // Skapa en ny karaktär med ett namn och Hp
        public Character(string name, int health)
        {
            Name = name;
            Health = health;
        }

        // Attackmetod för att minska motståndarens Hp
        public void BasicAttack(Character target)
        {
            Console.WriteLine($"{Name} attackerar {target.Name}!");
            target.Health -= 10; // Minska målets Hp med 10
        }
    }

    