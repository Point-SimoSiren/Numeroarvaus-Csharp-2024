// See https://aka.ms/new-console-template for more information


// Console.ForegroundColor = ConsoleColor.White;
// Console.BackgroundColor = ConsoleColor.Blue;

// Muuttujien esittely
int arvaus;
int arvottuLuku;
bool jatketaanko = true;


// Lista jonne arvaukset tallennetaan
List<int> arvaukset = new List<int>();

// Lukun arpominen
Random rnd = new Random();
arvottuLuku = rnd.Next(1, 10);

while (jatketaanko == true)
{
    Console.WriteLine("Arvaa luku väliltä 1-10");

    arvaus = int.Parse(Console.ReadLine()); // Otetaan käyttäjän syöte eli arvaus
    arvaukset.Add(arvaus); // Lisätään arvaus listalle


    if (arvaus > arvottuLuku)
    {
        Console.WriteLine("Arvottu luku on pienempi.");
    }
    else if (arvaus < arvottuLuku)
    {
        Console.WriteLine("Arvottu luku on suurempi.");
    }
    else
    {
        jatketaanko = false; // Tämänkertainen peli päättyy

        Console.WriteLine("Arvasit oikein! Onneksi olkoon! Oikea luku oli " + arvottuLuku);

        Console.WriteLine("Käytit yhteensä " + arvaukset.Count + " arvausta.");

        Console.WriteLine("Alla näet kaikki antamasi arvaukset:");

        // For silmukka eli for loop käy läpi kaikki arvaukset listalta
        for (int i = 0; i < arvaukset.Count; i++)
        {
            Console.WriteLine(i + 1 + ". arvauksesi oli: " + arvaukset[i]);
        }



    }
}

