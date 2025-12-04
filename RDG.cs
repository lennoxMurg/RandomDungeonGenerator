using System;

namespace Projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            int breite = 0;
            int hoehe = 0;

            do
            {
                try
                {

                    if (breite == 0)
                    {
                        Console.WriteLine("Bitte die Breite Eingeben!");
                        breite = Convert.ToInt32(Console.ReadLine());

                        if (breite < 10 || breite > 50)
                        {
                            throw new ArgumentException("\nDie Breite muss größer als 10 und kleiner als 50 sein .\n");
                        }

                    }

                    Console.WriteLine("Bitte die Höhe Eingeben!");
                    hoehe = Convert.ToInt32(Console.ReadLine());


                    if (hoehe < 10 || hoehe > 25)
                    {
                        throw new ArgumentException("\nDie Höhe muss größer als 10 und kleiner als 25 sein.\n");
                    }
                    break;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);

                }

            }
            while (true);

        }
    }
}