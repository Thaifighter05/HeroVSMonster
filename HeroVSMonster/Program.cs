using System;
using System.Collections.Generic;


static void Main(string[] args)
{
    List<Character> characters = new List<Character>
    {
        new Hero("Riddare", 100),
        new Monster("Drake", 80)
    };

    Console.WriteLine($"Strid startar: {characters[0].Name} vs {characters[1].Name}");

    bool battleOver = false;

    while (!battleOver)
    {
        // Hjälten attackerar
        if (characters[0] is Hero hero)
        {
            hero.HeroicAttack(characters[1]);
            hero.Heal();
        }
        else
        {
            characters[0].BasicAttack(characters[1]);
        }

        // Monstret attackerar
        if (characters[1] is Monster monster)
        {
            monster.FerociousAttack(characters[0]);
        }
        else
        {
            characters[1].BasicAttack(characters[0]);
        }

        // Kontrollera om någon av karaktärerna är död
        if (characters[0].Health <= 0 || characters[1].Health <= 0)
        {
            battleOver = true;
        }
        else
        {
            Console.WriteLine($"{characters[0].Name} Hälsa: {characters[0].Health}");
            Console.WriteLine($"{characters[1].Name} Hälsa: {characters[1].Health}");
            Console.WriteLine();
        }
    }

    Console.WriteLine("Striden är över!");
}

