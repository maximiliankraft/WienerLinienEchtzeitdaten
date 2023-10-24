namespace WienerLinienEchtzeitdaten
{
    public class Fahrwegverlauf
    {
        private int lineId;
        private string stopId;

        public Fahrwegverlauf(int lineId, string stopId)
        {
            this.lineId = lineId;
            this.stopId = stopId;
        }

        public int LineId
        {
            get => lineId;
            set => lineId = value;
        }

        public string StopId
        {
            get => stopId;
            set => stopId = value;
        }
    }
}