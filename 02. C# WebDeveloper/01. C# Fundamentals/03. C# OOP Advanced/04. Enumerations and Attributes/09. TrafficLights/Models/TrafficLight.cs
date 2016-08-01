namespace _09.TrafficLights.Models
{
    using Enums;

    public class TrafficLight
    {
        public TrafficLight(LightState light)
        {
            this.Light = light;
        }

        public LightState Light { get; set; }

        public void ChangeToNextLight()
        {
            if (this.Light == LightState.Red)
            {
                this.Light = LightState.Green;
            }
            else if (this.Light == LightState.Green)
            {
                this.Light = LightState.Yellow;
            }
            else if (this.Light == LightState.Yellow)
            {
                this.Light = LightState.Red;
            }
        }

        public override string ToString()
        {
            return this.Light.ToString();
        }
    }
}
