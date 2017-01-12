namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        static void Main()
        {
            ISound frog = new Frog(1, "Fro", "female");
            frog.Sound();

            ISound kiti = new Kitten(1, "kiti");
            kiti.Sound();

            ISound tom = new Tomcat(7, "Tom");
            tom.Sound();

            Animals[] animals1 =
            {
                new Dog(5, "Rex", "male"),
                new Frog(1, "Fro", "female"),
                new Cat(3, "Sisi", "female"),
                new Dog(3, "Mimi", "female"),
                new Frog(2, "Orf", "male"),
                new Tomcat(5, "Tomas"),
                new Kitten(2, "Fifi"),
                new Cat(4, "Isis", "female")
            };

            Animals[] animals2 =
            {
                new Dog(5, "Rex", "male"),
                new Frog(1, "Fro", "female"),
                new Cat(3, "Sisi", "female"),
                new Dog(3, "Mimi", "female"),
                new Frog(2, "Orf", "male"),
                new Tomcat(5, "Tomas"),
                new Kitten(2, "Fifi"),
                new Cat(4, "Isis", "female")
            };

            Console.WriteLine($"Cats, Years Average: {YearsAverage(animals1, typeof(Cat))}");
            Console.WriteLine($"Dogs, Years Average: {YearsAverage(animals1, typeof(Dog))}");
            Console.WriteLine($"Frogs, Years Average: {YearsAverage(animals1, typeof(Frog))}");
            Console.WriteLine($"Tomcat, Years Average: {YearsAverage(animals1, typeof(Tomcat))}");
            Console.WriteLine($"Kittens, Years Average: {YearsAverage(animals1, typeof(Kitten))}");
        }

        public static double YearsAverage(Animals[] animals, Type type)
        {
            var subset = animals
                        .Where(name => name.GetType() == type)
                        .Select(name => name.Age).Average();
            return subset;
        }
    }
}
