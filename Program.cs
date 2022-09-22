using Microsoft.VisualBasic;
using System.Drawing;
using System.Security.Cryptography;

namespace Zahlenratespiel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Fehler = false;
            do
            {
                //Variabeln
                Random Zufallszahl = new Random();
                int GeheimeZahl = Zufallszahl.Next(1, 100);
                bool Erraten = false;
                int Versuche = 0;
                bool nochmal;
                Fehler = false;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Zahlenratespiel");
                Console.WriteLine("Rate eine Zahl zwischen 1 und 100");

                //Code für Zahlenratespiel selbst
                do
                {
                    try
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        int GerateneZahl = (Convert.ToInt32(Console.ReadLine()));


                        //Test ob Zahl zwischen 1 und 100
                        if (GerateneZahl < 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Ungültige Eingabe");
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else if (GerateneZahl > 100)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Ungültige Eingabe");
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else
                        {
                            //Code für Zahl raten
                            Versuche = Versuche + 1;
                            String Ende = (Convert.ToString(Versuche));


                            if (GerateneZahl == GeheimeZahl)
                            {
                                //Ende und Frage ob man nochmal spielen will
                                Console.ForegroundColor = ConsoleColor.Green;
                                Erraten = true;
                                Console.WriteLine("Sie haben die Zahl in " + Ende + " Versuchen erraten");
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("");
                                Console.WriteLine("Wollen sie noch einmal spielen? true/false");
                                try
                                {
                                    nochmal = (Convert.ToBoolean(Console.ReadLine()));
                                    if (nochmal == true)
                                    {
                                        Fehler = true;

                                    }
                                    else
                                    {
                                        Environment.Exit(0);
                                    }
                                }
                                catch
                                {
                                    Environment.Exit(0);
                                }
                                //Geratene Zahl wird mit Geheimzahl verglichen
                            }
                            else if (GerateneZahl < GeheimeZahl)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Die geratene Zahl ist zu klein");

                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Die geratene Zahl ist zu gross");

                            }
                        }
                    }




                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Ungültige Eingabe");
                        Console.WriteLine("Geben sie nur Zahlen ein");
                    }





                } while (Erraten == false);
            } while (Fehler == true);

        }
    }
}