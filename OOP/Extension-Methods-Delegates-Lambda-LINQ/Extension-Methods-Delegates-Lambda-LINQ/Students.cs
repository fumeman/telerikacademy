namespace Extension_Methods_Delegates_Lambda_LINQ
{
    using System.Collections.Generic;

    public class Students
    {
        public Students(double age, string firstName, string lastName = "")
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Age { get; set; }
    }
}
