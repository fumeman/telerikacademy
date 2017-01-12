namespace School
{
    using System;
    using System.Collections.Generic;

    public class Class
    {
        private static IList<string> allIdentifiers = new List<string>();
        private string identifier;
        private string comments;
        private IList<Teacher> teachers;
        private IList<Student> students;

        public Class(string identifier, IList<Teacher> teachers, IList<Student> students, string comments = "")
        {
            bool isUniq = true;
            foreach (var id in allIdentifiers)
            {
                if (id == identifier)
                {
                    isUniq = false;
                    break;
                }
            }
            if (isUniq)
            {
                allIdentifiers.Add(identifier);
                this.identifier = identifier;
                this.comments = comments;
                this.students = students;
                this.teachers = teachers;
            }
            else
            {
                throw new System.Exception($"Class ID \"{identifier}\" is not unique!");
            }
        }

        public string Identifier
        {
            get
            {
                return this.identifier;
            }
        }

        public IList<Student> Students
        {
            get
            {
                return this.students;
            }
        }

        public IList<Teacher> Teachers
        {
            get
            {
                return this.teachers;
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
