namespace _06.TruckTour
{
    public class PetrolPump
    {
        public long AmountOfPetrol { get; set; }
        public long DistanceToNextPumn { get; set; }

        public override string ToString()
        {
            return AmountOfPetrol + " " + DistanceToNextPumn;
        }
    }
}
