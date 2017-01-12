namespace School
{
    public class Discipline
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;
        private string comments;

        public Discipline(string name, int numberOfLectures, int numberOfExercises, string comments = "")
        {
            this.name = name;
            this.numberOfLectures = numberOfLectures;
            this.numberOfExercises = numberOfExercises;
            this.comments = comments;
        }

        public string Name
        {
            get
            {
                return this.name;

            }

        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;

            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;

            }
        }

        public string Comments
        {
            get
            {
                return this.comments;

            }
        }
    }
}
