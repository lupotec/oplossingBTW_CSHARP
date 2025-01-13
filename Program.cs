using System;

class Program
{
    static void Main()
    {
        // Variabelen declareren en initialiseren
        string titel = "BTW-berekening"; // Titel
        string voorNaam = "Jan"; // Voornaam
        string familieNaam = "Jansen"; // Familienaam
        const int btw = 21; // BTW als constante
        string geldBedrag; // Het bedrag waarop BTW berekend wordt
        double buffer; // Variabele voor het BTW-bedrag

        // Titel weergeven
        Console.WriteLine(titel);
        Console.WriteLine();

        // Naam en voornaam weergeven
        Console.WriteLine(voorNaam + " " + familieNaam);
        Console.WriteLine();

        // Vraag de gebruiker om een bedrag in te voeren
        Console.Write("Voer een bedrag in: ");
        geldBedrag = Console.ReadLine();

        // Probeer de invoer om te zetten naar een double
        if (double.TryParse(geldBedrag, out double geldBedrag2))
        {
            // Bereken de BTW en het totaalbedrag
            buffer = (geldBedrag2 * btw) / 100;

            // Toon de BTW-berekening
            Console.WriteLine($"De BTW van {btw}% op het bedrag {geldBedrag2:F2} bedraagt {buffer:F2} euro.");
        }
        else
        {
            // Foutmelding bij ongeldige invoer
            Console.WriteLine("Ongeldige invoer! Zorg ervoor dat je een geldig getal invoert.");
        }
        Console.ReadKey();
    }

    
}
