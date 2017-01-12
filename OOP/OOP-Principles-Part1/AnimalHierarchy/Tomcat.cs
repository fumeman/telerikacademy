namespace AnimalHierarchy
{
    class Tomcat : Cat, ISound
    {
        private const string sex = "male";

        public Tomcat(double age, string name) : base(age, name, sex)
        {

        }

        public new void Sound()
        {
            AnimalSound("Grrrr...");
        }
    }
}