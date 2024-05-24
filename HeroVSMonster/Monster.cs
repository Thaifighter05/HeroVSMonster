 class Monster : Character
    {
        // Anropar basklassens konstruktor för att skapa ett monster
        public Monster(string name, int health) : base(name, health) { }
        
        //Attackmetod för monster/drake
        public void FerociousAttack(Character target)
        {
            Console.WriteLine($"{Name} attackerar våldsamt {target.Name}!");
            target.Health -= 12; //Minskar targets Hp med 12
        }
    }