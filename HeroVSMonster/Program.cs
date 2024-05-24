using System;
using System.Collections.Generic;

Main();

static void Main()
{

    // Skapa en lista med två karaktärer: en hjälte och ett monster
    List<Character> characters = new List<Character>
    {
        new Hero("Riddare", 100), // Skapa en hjälte med namnet "Riddare" och Hp 100 (index 0)
        new Monster("Drake", 80) // Skapa ett monster med namnet "Drake" och Hp 80 (index 1)
    };


    Console.WriteLine($"Strid startar: {characters[0].Name} vs {characters[1].Name}");

    bool battleOver = false; // Variabel för att hålla koll på om striden är över

    // Loop för att fortsätta striden tills den är över
    while (!battleOver)
    {
        // Hjälten attackerar
        if (characters[0] is Hero hero)
        {
            hero.HeroicAttack(characters[1]); // Hjältens attack
            hero.Heal(); // Hjältens healar
        }
        else
        {
            characters[0].BasicAttack(characters[1]); // Attackerar om det inte är en hjälte
        }

        // Monstret attackerar
        if (characters[1] is Monster monster)
        {
            monster.FerociousAttack(characters[0]); // Monstrets attack
        }
        else
        {
            characters[1].BasicAttack(characters[0]); // Attack om det inte är ett monster
        }

        // Kontrollera om någon av karaktärerna är död
        if (characters[0].Health <= 0 || characters[1].Health <= 0)
        {
            battleOver = true; // Markera att striden är över om någon karaktär är död
        }
        else
        {
            // Skriv ut Hp för varje karaktär om striden inte är över
            Console.WriteLine($"{characters[0].Name} Hälsa: {characters[0].Health}");
            Console.WriteLine($"{characters[1].Name} Hälsa: {characters[1].Health}");

        }
    }

    Console.WriteLine("Striden är över!"); // Skriver ut att striden är över när loopen avslutas
    Console.ReadLine();
}

