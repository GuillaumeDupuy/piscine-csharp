namespace CSharpDiscovery.Quest03
{
    public class HistoricalMonument : PointOfInterest
    {
        public int BuildYear { get; set; }

        public HistoricalMonument() {
            this.BuildYear = 0;
        }
        
        public HistoricalMonument(string name, double Latitude, double Longitude, int BuildYear) : base(name, Latitude, Longitude){
             this.BuildYear = BuildYear;

        }

        public override string ToString()
        {
            return Name + " is a historical monument built in " + BuildYear;
        }
    }
}