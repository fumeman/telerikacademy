namespace School
{
    public class People
    {
        private string name;
        private string comments;

        public People(string name, string comments = "")
        {
            this.name = name;
            this.comments = comments;
        }

        public string Name
        {
            get
            {
                return this.name;
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
