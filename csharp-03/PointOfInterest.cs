using System;

namespace CSharpDiscovery.Quest03

{
    public class PointOfInterest
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Name { get; set; }
        public static string GoogleMapsUrlTemplate { get; set; } = "https://www.google.com/maps/place/{0}/@{1},{2},15z/";

        public PointOfInterest() {
            Latitude = 44.854186;
            Longitude = -0.5663056;
            Name = "Bordeaux Ynov Campus";
        }

        public PointOfInterest(string name, double latitude, double longitude) {
            Latitude = latitude;
            Longitude = longitude;
            Name = name;
        }

        public string GetGoogleMapsUrl() {
            return GoogleMapsUrlTemplate.Replace("{0}", Name.Replace(' ', '+'))
                                        .Replace("{1}", Latitude.ToString())
                                        .Replace("{2}", Longitude.ToString());
        }

        public override string ToString() {
            return Name + " (Lat=" + Latitude.ToString() + ", Long=" + Longitude.ToString() + ")";
        }
        
        public int GetDistance(PointOfInterest other) {
            return GetDistance(other, this);
        }
        public static int GetDistance(PointOfInterest p1, PointOfInterest p2) {
           var rlat1 = Math.PI * p1.Latitude / 180;
            var rlat2 = Math.PI * p2.Latitude / 180;
            var rlon1 = Math.PI * p1.Longitude / 180;
            var rlon2 = Math.PI * p2.Longitude / 180;

            var theta = p1.Longitude - p2.Longitude;
            var rtheta = Math.PI * theta / 180;

            var dist = Math.Sin(rlat1) * Math.Sin(rlat2) + Math.Cos(rlat1) * Math.Cos(rlat2) * Math.Cos(rtheta);
            dist = Math.Acos(dist);
            dist = dist * 180 / Math.PI;
            dist = dist * 60 * 1.1515;

            return (int)(dist * 1.609344 + 1);

        }
        
    }

}

    