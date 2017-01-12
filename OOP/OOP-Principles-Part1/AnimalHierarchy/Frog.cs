namespace AnimalHierarchy
{
    public class Frog : Animals, ISound
    {
        public Frog(double age, string name, string sex) : base(age, name, sex)
        {

        }

        public void Sound()
        {
            AnimalSound("Kva-kvak");
        }
    }
}
