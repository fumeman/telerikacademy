namespace School
{
    using System.Collections.Generic;

    public class Student : People
    {
        private static IList<int> allNumbers = new List<int>();
        private int classNumber;

        public Student(string name, int classNumber, string comments = "") : base(name, comments)
        {
            bool isUniq = true;
            foreach (var number in allNumbers)
            {
                if (number == classNumber)
                {
                    isUniq = false;
                    break;
                }
            }
            if (isUniq)
            {
                allNumbers.Add(classNumber);
                this.classNumber = classNumber;
            }
            else
            {
                throw new System.Exception($"Student Number {classNumber} is not unique!");
            }
        }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
        }
    }
}
