namespace _06.RawData
{
    public class Car
    {
        public string model;
        public Engine engine;
        public Cargo cargo;
        public Tire[] tires = new Tire[4];

        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType, double tirePressure1, int tireAge1, double tirePressure2, int tireAge2, double tirePressure3, int tireAge3, double tirePressure4, int tireAge4)
        {
            this.model = model;
            this.engine = new Engine(engineSpeed, enginePower);
            this.cargo = new Cargo(cargoWeight, cargoType);
            this.tires[0] = new Tire(tirePressure1, tireAge1);
            this.tires[1] = new Tire(tirePressure2, tireAge2);
            this.tires[2] = new Tire(tirePressure3, tireAge3);
            this.tires[3] = new Tire(tirePressure4, tireAge4);
        }
    }
}
