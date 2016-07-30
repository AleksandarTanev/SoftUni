namespace _08.PetClinics.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class Clinic : IEnumerable<Room>
    {
        private string name;
        private Room[] rooms;

        public Clinic(string name, int rooms)
        {
            this.Name = name;
            this.Rooms = new Room[rooms];

            for (int i = 0; i < this.Rooms.Length; i++)
            {
                this.Rooms[i] = new Room();
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        private Room[] Rooms
        {
            get
            {
                return rooms;
            }

            set
            {
                if (value.Length % 2 == 0)
                {
                    throw new ArgumentException("The number of rooms in a clinic should not be uneven.");
                }

                rooms = value;
            }
        }

        public Room this[int index] => this.Rooms[index];

        public bool AddPet(Pet newPet)
        {
            Room firstEmptyRoom = null;

            foreach (var room in this.AddingEnumerable())
            {
                if (room.IsEmpty)
                {
                    firstEmptyRoom = room;
                    break;
                }
            }

            if (firstEmptyRoom != null)
            {
                firstEmptyRoom.AddPet(newPet);
                return true;
            }

            return false;
        }

        public bool ReleasePet()
        {
            Room firstNotEmptyRoom = null;

            foreach (var room in this.RemovingEnumerable())
            {
                if (!room.IsEmpty)
                {
                    firstNotEmptyRoom = room;
                    break;
                }
            }

            if (firstNotEmptyRoom != null)
            {
                firstNotEmptyRoom.ReleasePet();
                return true;
            }

            return false;
        }

        public bool HasEmptyRooms()
        {
            bool anyEmptyRooms = this.Any(r => r.IsEmpty);

            return anyEmptyRooms;
        }

        public IEnumerable<Room> AddingEnumerable()
        {
            if (this.Rooms.Length == 0)
            {
                yield break;
            }

            int midIndex = (this.Rooms.Length / 2 + 1) - 1;

            yield return this.Rooms[midIndex];

            int movingIndex = 1;
            while (movingIndex <= midIndex)
            {
                yield return this.Rooms[midIndex - movingIndex];
                yield return this.Rooms[midIndex + movingIndex];

                movingIndex++;
            }
        }

        public IEnumerable<Room> RemovingEnumerable()
        {
            if (this.Rooms.Length == 0)
            {
                yield break;
            }

            int midIndex = (this.Rooms.Length / 2 + 1) - 1;

            yield return this.Rooms[midIndex];

            int movingIndex = midIndex + 1;
            while (movingIndex < this.Rooms.Length)
            {
                yield return this.Rooms[movingIndex];

                movingIndex++;
            }

            movingIndex = 0;
            while (movingIndex < midIndex)
            {
                yield return this.Rooms[movingIndex];

                movingIndex++;
            }
        }

        public IEnumerator<Room> GetEnumerator()
        {
            for (int i = 0; i < this.Rooms.Length; i++)
            {
                yield return this.Rooms[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            string result = string.Join("\n", this);

            return result;
        }
    }
}
