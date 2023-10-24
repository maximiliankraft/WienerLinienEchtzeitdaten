using System;
using System.Collections.Generic;
using System.IO;

namespace WienerLinienEchtzeitdaten
{
    internal class Program
    {

        public static Fahrwegverlauf[] readFahrwegverlaufFromFile(string filepath)
        {
            
        }

        public static Haltepunkt[] readHaltepunkteFromFile(string filepath)
        {
            // liste anlegen, ähnlich wie ein array nur das der speicher dynamisch allokiert werden kann
            List<Haltepunkt> linien = new List<Haltepunkt>();

            // datei als stream öffnen
            FileStream fs = File.OpenRead(filepath);
            
            // hilfsklasse zum stream zeilenweise lesen
            StreamReader reader = new StreamReader(fs);

            // so lange die datei lesen bis der stream zu ende ist
            while (!reader.EndOfStream)
            {
                // nächste zeile einlesen
                string lineStr = reader.ReadLine();
                
                // zeile beim semikolon in teilstrings aufsplitten
                string[] values = lineStr.Split(';');

                

                // values[0] == LineId
                // values[1] == LineText
                
                // Klasse linie anlegen
                Linie line = new Linie();
                
                // aus den eingelesenen values die klasse aufbauen
                try
                {
                    line.LineId = int.Parse(values[0]);
                }
                catch (Exception e)
                {
                    // Console.WriteLine(e);
                    continue;
                }
                
                line.LineText = values[1];
                
                // klasse zur liste hinzufügen
                linien.Add(line);
            }

            // die liste (konvertiert als array) zurückgeben 
            return linien.ToArray();
        }
        
        public static Linie[] readLinesFromFile(string filepath)
        {
            // liste anlegen, ähnlich wie ein array nur das der speicher dynamisch allokiert werden kann
            List<Linie> linien = new List<Linie>();

            // datei als stream öffnen
            FileStream fs = File.OpenRead(filepath);
            
            // hilfsklasse zum stream zeilenweise lesen
            StreamReader reader = new StreamReader(fs);

            // so lange die datei lesen bis der stream zu ende ist
            while (!reader.EndOfStream)
            {
                // nächste zeile einlesen
                string lineStr = reader.ReadLine();
                
                // zeile beim semikolon in teilstrings aufsplitten
                string[] values = lineStr.Split(';');

                

                // values[0] == LineId
                // values[1] == LineText
                
                // Klasse linie anlegen
                Linie line = new Linie();
                
                // aus den eingelesenen values die klasse aufbauen
                try
                {
                    line.LineId = int.Parse(values[0]);
                }
                catch (Exception e)
                {
                    // Console.WriteLine(e);
                    continue;
                }
                
                line.LineText = values[1];
                
                // klasse zur liste hinzufügen
                linien.Add(line);
            }

            // die liste (konvertiert als array) zurückgeben 
            return linien.ToArray();
        }

        public static void Main(string[] args)
        {
            Linie l1 = new Linie();

            Linie[] linienWien = 
                readLinesFromFile(
                    // der pfad ist bei jedem anders
                    "C:\\Users\\max\\Downloads\\wienerlinien-ogd-linien(1).csv"
                );

            Haltepunkt[] haltepunkte = readHaltepunkteFromFile("");

            Haltepunkt h = new Haltepunkt();
            h.StopText = "NameHaltestelle";
            
            Console.WriteLine(linienWien);
        }
    }
}