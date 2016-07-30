namespace _08.PetClinics.Models
{
    public class Room
    {
        private bool isEmpty;
        private Pet pet;

        public Room()
        {
            this.IsEmpty = true;
            this.Pet = null;
        }

        public bool IsEmpty
        {
            get
            {
                return isEmpty;
            }

            set
            {
                isEmpty = value;
            }
        }

        public Pet Pet
        {
            get
            {
                return pet;
            }

            set
            {
                pet = value;
            }
        }

        public bool AddPet(Pet newPet)
        {
            if (this.IsEmpty)
            {
                this.Pet = newPet;
                this.IsEmpty = false;

                return true;
            }

            return false;
        }

        public bool ReleasePet()
        {
            if (!this.IsEmpty)
            {
                this.Pet = null;
                this.IsEmpty = true;

                return true;
            }

            return false;
        }

        public override string ToString()
        {
            string result;

            if (IsEmpty)
            {
                result = "Room empty";
            }
            else
            {
                result = this.Pet.ToString();
            }

            return result;
        }
    }
}
