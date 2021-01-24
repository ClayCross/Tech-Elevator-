namespace Individual.Exercises.Classes
{

    public class Elevator
    {
        int capacity = 10;
        public int CurrentLevel { get; private set; } = 1;

        public int NumberOfLevels { get; private set; }

        public bool DoorIsOpen { get; private set; }

        public Elevator(int numberOFLevels)
        {
            this.NumberOfLevels = numberOFLevels;


        }
        public Elevator(int numberOfLevels, int capacity)
        {
            this.NumberOfLevels = numberOfLevels;
            this.capacity = capacity;
        }

        public void OpenDoor()
        {
            this.DoorIsOpen = true;
        }
        public void CloseDoor()
        {
            this.DoorIsOpen = false;
        }

        public void GoUp(int desiredFloor)
        {
            if (this.DoorIsOpen || desiredFloor <= this.CurrentLevel || desiredFloor > this.NumberOfLevels)
            {
                return;
            }

            this.CurrentLevel = desiredFloor;

            
        }

        public void GoDown(int desiredFloor)
        {
            if (this.DoorIsOpen || desiredFloor >= this.CurrentLevel || desiredFloor < 1)
            {
                return;
            }

            this.CurrentLevel = desiredFloor;
        }


        


    }

}
