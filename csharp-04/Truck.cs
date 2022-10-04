namespace CSharpDiscovery.Quest04
{
    public class Truck : Vehicule
    {
        public int Tonnage {get; set; }

        public Truck() {
            this.Tonnage = 0;
        }

        public Truck(int Tonnage, string Brand, string Color, int CurrentSpeed = 0) : base(Brand, Color, CurrentSpeed) {
            this.Tonnage = Tonnage;
        }

        public override string ToString()
        {
            return Color + " " + Brand + " " + Tonnage + "T Truck";
        }

        public override void Accelerate(int Speed)
        {
            CurrentSpeed += Speed;
            if (CurrentSpeed > 100) {
                CurrentSpeed = 100;
            }
        }
        
        public override void Brake(int BrakePower)
        {
            CurrentSpeed -= BrakePower;
            if (CurrentSpeed < 0) {
                CurrentSpeed = 0;
            }
            {
                
            }
        }
    }
}