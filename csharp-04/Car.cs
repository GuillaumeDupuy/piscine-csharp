namespace CSharpDiscovery.Quest04
{
    public class Car : Vehicule 
    {
        public string Model {get; set;}

        public Car() {
            this.Model = "Unknown";
        }

        public Car( string model, string brand, string color, int currentSpeed) : base(brand, color, currentSpeed) {
            this.Model = model;
        }

        public override string ToString()
        {
            return Color + " " + this.Brand + " " + this.Model;
        }

        public override void Accelerate(int Speed)
        {
            CurrentSpeed += Speed;
            if (CurrentSpeed > 180 ) {
                CurrentSpeed = 180;
            }
            
        }

        public override void Brake(int BrakePower)
        {   
            CurrentSpeed -= BrakePower;
            if(CurrentSpeed < 0) {
                CurrentSpeed = 0;
            }
        }
    }
}