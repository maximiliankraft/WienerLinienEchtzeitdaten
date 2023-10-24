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