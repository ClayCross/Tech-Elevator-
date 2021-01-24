namespace Individual.Exercises.Classes
{
    public class HomeworkAssignment
    {
        public int EarnedMarks { get; set; }

        public int PossibleMarks { get; set; }

        public string SubmitterName { get; private set; }

        public string LetterGrade
        {
            get
            {
                if (this.PossibleMarks <= 0)
                {
                    return "??";
                }

                double percent = (this.EarnedMarks * 100.0) / this.PossibleMarks;

                if (percent >= 90)
                {
                    return "A";
                }
                else if (percent >= 80)
                {
                    return "B";
                }
                else if (percent >= 70)
                {
                    return "C";
                }
                else if (percent >= 60)
                {
                    return "D";
                }
                {
                    return "F";
                }

                



            }






        }

        public HomeworkAssignment(int possibleMarks, string submitterName)
        {
            this.SubmitterName = submitterName;
            this.PossibleMarks = possibleMarks;

            
        }



    }
}

