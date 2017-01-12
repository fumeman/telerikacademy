namespace AnimalHierarchy
{
    public class Animals
    {
        private double age;
        private string name;
        private string sex;

        public Animals(double age, string name, string sex)
        {
            this.age = age;
            this.name = name;
            this.sex = sex;
        }

        public double Age
        {
            get { return this.age; }
        }

        public string Name
        {
            get { return this.name; }
        }

        public string Sex { get { return this.sex; } }

        internal void AnimalSound(string sound)
        {
            System.Console.WriteLine(sound);
        }
    }
}
