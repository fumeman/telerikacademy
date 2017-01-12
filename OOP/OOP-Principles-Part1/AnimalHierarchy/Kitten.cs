namespace AnimalHierarchy
{
    public class Kitten : Cat, ISound
    {
        private const string sex = "female";

        public Kitten(double age, string name) : base(age, name, sex)
        {
            
        }

        public new void Sound()
        {
            AnimalSound("Meow");
        }
    }
}
