 class Hero : Character
    {
        //Anropar basklassens konstruktor för att skapa en hjälte
        public Hero(string name, int health) : base(name, health) { }

        //Attackmetod för hjälten
        public void HeroicAttack(Character target)
        {
            Console.WriteLine($"{Name} attackerar heroiskt {target.Name}!");
            target.Health -= 15; // Minska målets hälsa med 15
        }
        // Metod för att heala hjälten och öka dess Hp
         public void Heal()
        {
            Console.WriteLine($"{Name} läker!");
            Health += 10; // Öka hjältens Hp med 10
        }
    }

    