namespace AnimalHierarchy
{
    public class Dog : Animals, ISound
    {
        public Dog(double age, string name, string sex) : base(age, name, sex)
        {

        }

        public void Sound()
        {
            AnimalSound("Baf-baf");
        }
    }
}
