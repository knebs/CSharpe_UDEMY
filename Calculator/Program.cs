﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            /// <summary>
            /// Das ist eine Zusammenfassung für die Klasse
            /// </summary>

            //User Story: Als Benutzer möchte ich zwei Zahlen eingeben, um deren Summe zu berechnen.
            Console.Write("Bitte geben Sie den ersten Summanden ein: ");
            string ersterSummand = Console.ReadLine();
            Console.Write("Bitte geben Sie den zweiten Summanden ein: ");
            string zweiterSummand = Console.ReadLine();

            //Wandel Text in Ganzzahlen um
            double ersterSummandAlsZahl = Convert.ToDouble(ersterSummand);
            double zweiterSummandAlsZahl = Convert.ToDouble(zweiterSummand);

            //Berechnung ausführen
            double summe = Addiere(ersterSummandAlsZahl, zweiterSummandAlsZahl);

            //Ausgabe
            Console.WriteLine("Die Summe ist: {0}", summe);
            WarteAufBenutzereingabe();

        }

        static double Addiere(double ersterSummandAlsZahl, double zweiterSummandAlsZahl)
        {

            double ergebnis = ersterSummandAlsZahl + zweiterSummandAlsZahl;
            return ergebnis;
        }

        static void WarteAufBenutzereingabe()
        {
            Console.Write("Zum Beenden bitte die Return-Taste drücken");
            Console.ReadLine();
        }

       
        

        }
    }

    

