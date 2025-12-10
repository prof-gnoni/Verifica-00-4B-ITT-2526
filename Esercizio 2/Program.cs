using System;
using LibreriaVeicoli;

namespace Esercizio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Guid, Veicolo> officina = new Dictionary<Guid, Veicolo>();
            bool continua = true;

            while (continua)
            {
                Console.WriteLine("\n--- OFFICINA MECCANICA ---");
                Console.WriteLine("1. Registra Veicolo");
                Console.WriteLine("2. Cerca Veicolo per ID");
                Console.WriteLine("3. Esci");
                Console.Write("Scelta: ");
                string scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        Console.Write("Marca: "); string marca = Console.ReadLine();
                        Console.Write("Modello: "); string modello = Console.ReadLine();
                        Console.Write("Anno: "); int anno = int.Parse(Console.ReadLine());

                        Veicolo v = new Veicolo(marca, modello, anno);
                        officina.Add(v.Id, v);

                        Console.WriteLine($"Veicolo registrato. ID: {v.Id}");
                        break;

                    case "2":
                        Console.Write("Inserisci l'ID da cercare (incolla qui): ");
                        string inputUtente = Console.ReadLine();

                        try
                        {
                            
                            Guid idDaCercare = Guid.Parse(inputUtente);

                            if (officina.ContainsKey(idDaCercare))
                            {
                                Console.WriteLine("Veicolo Trovato: " + officina[idDaCercare].ToString());
                            }
                            else
                            {
                                Console.WriteLine("Nessun veicolo trovato con questo ID."); // [cite: 44]
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("ID non valido.");
                        }
                        break;

                    case "3":
                        continua = false;
                        break;
                }
            }
        }
    }
}