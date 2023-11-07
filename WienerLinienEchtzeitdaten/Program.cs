using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace WienerLinienEchtzeitdaten
{
    internal class Program
    {

        public static Fahrwegverlauf[] readFahrwegverlaufFromFile(string filepath)
        {
            List<Fahrwegverlauf> fahrwegverlaeufe = new List<Fahrwegverlauf>();
            FileStream fs = File.OpenRead(filepath); // öffnet die datei
            StreamReader reader = new StreamReader(fs); // liest die datei zeilenweisen ein

            // LineId am Index 0
            // StopId am Index 3

            while (!reader.EndOfStream)
            {
                string fileLine = reader.ReadLine();
                string[] fileLineCells = fileLine.Split(';');

                int lineId = int.Parse(fileLineCells[0]);
                int stopId = int.Parse(fileLineCells[3]);

                Fahrwegverlauf fahrwegverlauf = new Fahrwegverlauf(lineId, stopId);
                fahrwegverlaeufe.Add(fahrwegverlauf);
            }

            return fahrwegverlaeufe.ToArray();

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
                string lineStr = reader.ReadLine(); // "302;U2;2;0;ptMetro"
                
                // zeile beim semikolon in teilstrings aufsplitten
                string[] values = lineStr.Split(';'); // ["302","U2","2","0","ptMetro"]

                

                // values[0] == LineId
                // values[1] == LineText
                
                // Klasse linie anlegen
                Haltepunkt haltepunkt = new Haltepunkt();
                
                // aus den eingelesenen values die klasse aufbauen
                try
                {
                    haltepunkt.StopId = int.Parse(values[0]);
                }
                catch (Exception e)
                {
                    // überspringen des schleifendurchgangs
                    continue;
                }
                
                haltepunkt.StopText = values[1];
                
                // klasse zur liste hinzufügen
                linien.Add(haltepunkt);
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

            Haltepunkt[] haltepunkte = 
                readHaltepunkteFromFile("C:\\Users\\max\\Downloads\\wienerlinien-ogd-haltepunkte(1).csv");

            Fahrwegverlauf[] verlauefe =
                readFahrwegverlaufFromFile("C:\\Users\\max\\Downloads\\wienerlinien-ogd-fahrwegverlaeufe(1).csv");
            
            // todo: alle Haltepunkte sollen zur entsprechenden Linie
            // hinzugefügt werden. Basierend auf den Fahrwegverläufen

            var x = 1;
            
            foreach (var fahrwegverlauf in verlauefe)
            {
                int currentLineId = fahrwegverlauf.LineId;
                // todo: linien objekt finden anhand der lineId
                
            }
            
            
            Console.WriteLine(linienWien);
        }
    }
}