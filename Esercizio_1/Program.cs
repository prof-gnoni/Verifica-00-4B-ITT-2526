using System;
using LibreriaVeicoli;

namespace Esercizio_1
{
    internal class Program
    {
        // Questo è l'UNICO Main che deve esistere in questo file
        static void Main(string[] args)
        {
            List<Veicolo> parcheggio = new List<Veicolo>();
            bool continua = true;

            while (continua)
            {
                Console.WriteLine("\n--- GESTIONE PARCHEGGIO ---");
                Console.WriteLine("1. Ingresso Veicolo");
                Console.WriteLine("2. Visualizza Veicoli");
                Console.WriteLine("3. Esci");
                Console.Write("Scelta: ");
                string scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        Console.Write("Inserisci Marca: ");
                        string marca = Console.ReadLine();
                        Console.Write("Inserisci Modello: ");
                        string modello = Console.ReadLine();
                        Console.Write("Inserisci Anno: ");

                        // Per semplicità non gestisco l'errore se scrivi lettere invece di numeri
                        int anno = int.Parse(Console.ReadLine());

                        Veicolo nuovoVeicolo = new Veicolo(marca, modello, anno);
                        parcheggio.Add(nuovoVeicolo);
                        Console.WriteLine("Veicolo parcheggiato!");
                        break;

                    case "2":
                        Console.WriteLine("\nVeicoli nel parcheggio:");
                        foreach (Veicolo v in parcheggio)
                        {
                            Console.WriteLine(v.ToString());
                        }
                        break;

                    case "3":
                        continua = false;
                        break;

                    default:
                        Console.WriteLine("Scelta non valida.");
                        break;
                }
            }
        }
    }
}