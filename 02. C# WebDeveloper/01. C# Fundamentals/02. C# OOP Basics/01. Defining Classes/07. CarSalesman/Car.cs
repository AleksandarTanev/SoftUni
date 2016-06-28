namespace _07.CarSalesman
{
    public class Car
    {
        public string model;
        public Engine engine;

        public int weight;
        public string color;

        public Car(string model, Engine engine, int weight, string color)
        {
            this.model = model;
            this.engine = engine;
            this.weight = weight;
            this.color = color;
        }

        public Car(string model, Engine engine, string color) : this(model, engine, -1, color)
        { }

        public Car(string model, Engine engine, int weight) : this(model, engine, weight, "n/a")
        { }

        public Car(string model, Engine engine) : this(model, engine, -1, "n/a")
        { }

        public override string ToString()
        {
            string output = string.Empty;

            string engDisp = this.engine.displacement != -1 ? this.engine.displacement.ToString() : "n/a";

            output += $"{this.model}:\n";
            output += string.Format($"  {this.engine.model}:\n");
            output += string.Format($"    Power: {this.engine.power}\n");
            output += string.Format($"    Displacement: {engDisp}\n");
            output += string.Format($"    Efficiency: {this.engine.efficiency}\n");

            string carWeight = this.weight != -1 ? this.weight.ToString() : "n/a";
            output += string.Format($"  Weight: {carWeight}\n");
            output += string.Format($"  Color: {this.color}");

            return output;
        }
    }
}
