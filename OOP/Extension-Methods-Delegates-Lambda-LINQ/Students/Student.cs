namespace Students
{
    using System.Collections.Generic;

    public class Student
    {
        public Student(string firstName, string lastName, int fn, string tel, string email, List<byte> marks, byte groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int FN { get; set; }

        public string Tel { get; set; }

        public string Email { get; set; }

        public List<byte> Marks { get; set; }

        public byte GroupNumber { get; set; }
    }
}
