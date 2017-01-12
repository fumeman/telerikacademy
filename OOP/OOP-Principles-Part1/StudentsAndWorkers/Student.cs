namespace StudentsAndWorkers
{
    public class Student : Human
    {
        private double grade;

        public Student(string firstName, string lastName, double grade) : base(firstName, lastName)
        {
            this.grade = grade;
        }

        public double Grade
        {
            get
            {
                return this.grade;
            }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} {this.Grade}";
        }
    }
}
