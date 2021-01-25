namespace Individual.Exercises.Classes
{
    public class Airplane
    {

        public string PlaneNumber { get; }


        public int BookedFirstClassSeats { get; private set; }


        public int AvailableFirstClassSeats
        {
            get { return TotalFirstClassSeats - BookedFirstClassSeats; }
        }

        public int TotalFirstClassSeats { get; }

        public int BookedCoachSeats { get; private set; }

        public int AvailableCoachSeats
        {
            get { return TotalCoachSeats - BookedCoachSeats; }
        }

        public int TotalCoachSeats { get; }

        public Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats)
        {
            this.PlaneNumber = planeNumber;
            this.TotalFirstClassSeats = totalFirstClassSeats;
            this.TotalCoachSeats = totalCoachSeats;
        }

        public bool ReserveSeats(bool firstClass, int totalNumberOfSeats)
        {
            if (firstClass)
            {
                if (totalNumberOfSeats > AvailableFirstClassSeats)
                {
                    return false;
                }

                BookedFirstClassSeats += totalNumberOfSeats;
            }
            else
            {
                if (totalNumberOfSeats > AvailableCoachSeats)
                {
                    return false;
                }

                BookedCoachSeats += totalNumberOfSeats;
            }

            return true;
        }
    }
}