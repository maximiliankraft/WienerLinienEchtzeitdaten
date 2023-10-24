namespace WienerLinienEchtzeitdaten
{
    public class Fahrwegverlauf
    {
        private int lineId;
        private int stopId;

        public Fahrwegverlauf(int lineId, int stopId)
        {
            this.lineId = lineId;
            this.stopId = stopId;
        }

        public int LineId
        {
            get => lineId;
            set => lineId = value;
        }

        public int StopId
        {
            get => stopId;
            set => stopId = value;
        }
    }
}