namespace AnimalHierarchy
{
    public class Cat : Animals, ISound
    {
        public Cat(double age, string name, string sex) : base(age, name, sex)
        {

        }

        public void Sound()
        {
            AnimalSound("Mew");
        }
    }
}
