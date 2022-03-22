using System;
using System.Collections;
using System.Collections.Generic;

namespace Opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<leerling> Leerlingen = new List<leerling>();
            int keuze;
            string antwoord = "";

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine("1) Leerling toevoegen");
                Console.WriteLine("2) Gegevens aanpassen");
                Console.WriteLine("3) Gegevens bekijken");
                Console.WriteLine("4) Exit");
                Console.Write("\n Keuze: ");
                keuze = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                if (keuze <= 4)
                {
                    switch (keuze)
                    {
                        case 1:
                            {
                                do
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Leerlingen.Add(Toevoegen(Leerlingen));

                                    Console.Write("Wilt u nog een leerling toevoegen?(J/N): ");
                                    antwoord = Console.ReadLine();
                                } while (antwoord.ToUpper() == "J");
                            }
                            break;

                        case 2:
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Aanpassen(Leerlingen);
                            }
                            break;

                        case 3:
                            {
                                Weergeven(Leerlingen);

                                Console.ReadLine();
                            }
                            break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                    Console.WriteLine("Dit is geen geldige optie!");
                    Console.ReadLine();
                }
            } while (keuze != 4);
            Console.ReadLine();
        }

        private static leerling Toevoegen(List<leerling> Leerlingen)
        {
            Console.Clear();
            leerling Leerling = new leerling();

            Console.Write("Geef de voornaam van de leerling in: ");
            Leerling.Voornaam = Console.ReadLine();
            Console.Write("Geef de achternaam van de leerling in: ");
            Leerling.Achternaam = Console.ReadLine();
            Console.Write("Geef de klas van de leerling in: ");
            Leerling.Klas = Console.ReadLine();

            return (Leerling);
        }

        private static void Aanpassen(List<leerling> Leerlingen)
        {
            Console.Clear();
            leerling Leerling = new leerling();
            int Nummer;

            Console.WriteLine("Er zijn {0} leerlingen ingegeven", Leerlingen.Count);
            Console.Write("Welke leerling wilt u aanpassen? ");
            Nummer = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.Write("Geef de voornaam van de leerling in: ");
            Leerling.Voornaam = Console.ReadLine();
            Console.Write("Geef de achternaam van de leerling in: ");
            Leerling.Achternaam = Console.ReadLine();
            Console.Write("Geef de klas van de leerling in: ");
            Leerling.Klas = Console.ReadLine();

            Leerlingen.RemoveAt(Nummer - 1);
            Leerlingen.Insert(Nummer - 1, Leerling);
        }

        private static void Weergeven(List<leerling> Leerlingen)
        {
            Console.Clear();


            if (Leerlingen.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;

                Console.WriteLine("Er zijn nog geen leerlingen ingegeven!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;

                int teller = 1;
                foreach (leerling Leerling in Leerlingen)
                {
                    Console.WriteLine("Leerling {0}:", teller);
                    Console.WriteLine("naam: " + Leerling.Voornaam + " " + Leerling.Achternaam);
                    Console.WriteLine("klas: {0}", Leerling.Klas);
                    Console.WriteLine();
                    teller++;

                    //REMEMBER!!
                    //Optie 2: (check class)

                    //Console.WriteLine(Leerling);
                    //Leerling.Teller++;
                }
            }
        }
    }
}
