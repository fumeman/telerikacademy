namespace Extension_Methods_Delegates_Lambda_LINQ
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        static void Main()
        {
            ////Problem 1.StringBuilder.Substring

            string str = "0123456789";

            Console.WriteLine("Problem 1:");
            Console.WriteLine(str.SubString(3, 5));

            ////Problem 2.IEnumerable extensions

            double[] arr = { 1, 2.3, 3, 4, 5, 6, 7, 0.3, 8, 9 };

            Console.WriteLine();
            Console.WriteLine("Problem 2:");
            Console.WriteLine($"{arr.sum()} = {arr.Sum()}");
            Console.WriteLine($"{arr.product()}");
            Console.WriteLine($"{arr.min()} = {arr.Min()}");
            Console.WriteLine($"{arr.max()} = {arr.Max()}");
            Console.WriteLine($"{arr.average()} = {arr.Average()}");

            ////Problem 3.First before last

            Students[] students = new Students[8];
            students[0] = new Students(23, "Morro", "Wind");
            students[1] = new Students(17, "BioS", "Hock");
            students[2] = new Students(28, "The Darkness");
            students[3] = new Students(38, "Dax", "Ter");
            students[4] = new Students(43, "System", "Shock");
            students[5] = new Students(19, "Pesho", "Peshov");
            students[6] = new Students(19.5, "Gosho", "Goshov");
            students[7] = new Students(22.3, "Gosho", "Peshev");

            Console.WriteLine();
            Console.WriteLine("Problem 3:");
            foreach (var name in FirstNameBeforeLast(students))
            {
                Console.WriteLine(name);
            }

            ////Problem 4.Age range

            Console.WriteLine();
            Console.WriteLine("Problem 4:");
            foreach (var name in NamesFromAgeBetween18and24_LINQ(students))
            {
                Console.WriteLine(name);
            }

            ///*Problem 5.Order students
   
            Console.WriteLine();
            Console.WriteLine("Problem 5:");
            foreach (var name in NamesDescendingOrder(students))
            {
                Console.WriteLine(name);
            }

            foreach (var name in NamesDescendingOrder_LINQ(students))
            {
                Console.WriteLine(name);
            }
        }

        public static IEnumerable<string> FirstNameBeforeLast(Students[] students)
        {
            var subset = from name in students
                         where name.FirstName.CompareTo(name.LastName) == -1
                         orderby name.FirstName, (name.FirstName + " " + name.LastName).Length
                         select $"Fist name before last: { name.FirstName} {name.LastName}";
            return subset;
        }

        public static IEnumerable<string> NamesDescendingOrder(Students[] students)
        {
            var subset = students
                        .OrderByDescending(name => (name.FirstName + name.LastName))
                        .ThenByDescending(name => (name.FirstName + " " + name.LastName).Length)
                        .Select(name => $"Descending Order: { name.FirstName} {name.LastName}");
            return subset;
        }

        public static IEnumerable<string> NamesDescendingOrder_LINQ(Students[] students)
        {
            var subset = from name in students
                         orderby (name.FirstName + name.LastName) descending,
                         (name.FirstName + " " + name.LastName).Length descending
                         select $"Descending Order with LINQ: { name.FirstName} {name.LastName}";
            return subset;
        }

        public static IEnumerable<string> NamesFromAgeBetween18and24_LINQ(Students[] students)
        {
            var subset = from name in students
                         where name.Age > 18 && name.Age < 24
                         orderby (name.FirstName + name.LastName) descending,
                         (name.FirstName + " " + name.LastName).Length descending
                         select $"Between 18 and 24: { name.FirstName} {name.LastName} - {name.Age} years";
            return subset;
        }
    }
}