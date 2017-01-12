namespace School
{
    using System.Collections.Generic;

    public class Teacher : People
    {
        private IList<Discipline> disciplines;

        public Teacher(string name, IList<Discipline> disciplines, string comments = "") : base(name, comments)
        {
            this.disciplines = disciplines;
        }

        public IList<Discipline> Disciplines
        {
            get
            {
                return this.disciplines;
            }
        }
    }
}
