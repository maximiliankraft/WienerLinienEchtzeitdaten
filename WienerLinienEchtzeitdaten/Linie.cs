using System;
using System.Collections.Generic;

namespace WienerLinienEchtzeitdaten
{
    public class Linie
    {
        // Attribute der Klasse
        private int lineID;
        private string lineText;
        
        private List<Haltepunkt> _haltepunkte;

        void addHaltepunkt(Haltepunkt h)
        {
            _haltepunkte.Add(h);
        }

        // Methode der Klasse
        private int checkLineId(int value)
        {
            if (value < 0)
            {
                //throw new ArgumentException("line id less than 1");
                Console.WriteLine("line id less than 1");
                return 1;
            }
            else
            {
                return value;
            }
        }

        public int LineId
        {
            get => lineID; // holen der private variable `lineID`
            set => lineID = checkLineId(value); // setzen der private variable `lineID`,
                                                // via der methode checkLineId
        }

        /*
         * name der Linie
         */
        public string LineText
        {
            get => lineText;
            set => lineText = value;
        }

        // todo
        // getHaltepunkte()...
    }
}