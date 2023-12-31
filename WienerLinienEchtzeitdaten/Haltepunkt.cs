﻿using System.Collections.Generic;

namespace WienerLinienEchtzeitdaten
{
    public class Haltepunkt
    {
        private int stopId;
        private string stopText;

        public Haltepunkt(int stopId, string stopText)
        {
            this.StopId = stopId;
            this.StopText = stopText;
        }

        public override string ToString()
        {
            return "ID: " + stopId + " Name: " + stopText;
        }

        public Haltepunkt()
        {
        }

        public int StopId
        {
            get => stopId;
            set => stopId = value;
        }

        public string StopText
        {
            get => stopText;
            set => stopText = value;
        }
        

    }
}