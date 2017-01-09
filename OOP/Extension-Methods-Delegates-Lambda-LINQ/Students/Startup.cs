namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        static void Main()
        {
            List<Student> student = new List<Student>();
            student.Add(new Student("Gosho", "Peshev", 7654673, "+359123456789", "email@abv.bg", new List<byte> { 2, 2, 3 }, 2));
            student.Add(new Student("Pesho", "Peshev", 7654671, "+359223456789", "email@dot.net", new List<byte> { 5, 6 }, 1));
            student.Add(new Student("Stamat", "Peshev", 7054670, "+359123456789", "email@dot.net", new List<byte> { 3, 4, 5 }, 3));
            student.Add(new Student("Tosho", "Peshev", 7654674, "+35923456789", "email@dot.net", new List<byte> { 3, 4, 5, 6 }, 2));
            student.Add(new Student("Mata", "Mateva", 7654675, "+359223456789", "email@dot.net", new List<byte> { 3, 4 }, 3));
            student.Add(new Student("Gaga", "Gagova", 7064679, "+359123456789", "email@abv.bg", new List<byte> { 3, 4, 5, 6 }, 1));
            student.Add(new Student("Titi", "Titov", 7054678, "+35923456789", "email@dot.net", new List<byte> { 3, 2, 5, 6 }, 2));

            ////Problem 9.Student groups

            Console.WriteLine("Problem 9:");
            List<Student> studentsGroup2Lambda = new List<Student>();

            List<Student> studentsGroup2LINQ = new List<Student>();

            foreach (var name in StudentsGroup_LINQ(student, 2))
            {
                studentsGroup2LINQ.Add(name);
                Console.WriteLine($"{name.FirstName} {name.LastName} - group {name.GroupNumber}");
            }

            ////Problem 10.Student groups extensions

            Console.WriteLine();
            Console.WriteLine("Problem 10:");
            List<Student> extStudentsLINQ = new List<Student>();

            Console.WriteLine();
            Console.WriteLine("Ext.LINQ");
            foreach (var name in student.studentsGroup_LINQ(2))
            {
                extStudentsLINQ.Add(name);
                Console.WriteLine($"{name.FirstName} {name.LastName} - group {name.GroupNumber}");
            }

            List<Student> extStudentsLambda = new List<Student>();

            Console.WriteLine();
            Console.WriteLine("Ext.Lambda");
            foreach (var name in student.studentsGroup_Lambda(2))
            {
                extStudentsLINQ.Add(name);
                Console.WriteLine($"{name.FirstName} {name.LastName} - group {name.GroupNumber}");
            }

            ////Problem 11.Extract students by email

            Console.WriteLine();
            Console.WriteLine("Problem 11:");
            foreach (var name in Email_LINQ(student))
            {
                Console.WriteLine($"{name.FirstName} {name.LastName} - email: {name.Email}");
            }

            ////Problem 12.Extract students by phone

            Console.WriteLine();
            Console.WriteLine("Problem 12:");
            foreach (var name in SofiaPhoneNumbers(student))
            {
                Console.WriteLine($"{name.FirstName} {name.LastName} - tel: {name.Tel}");
            }

            ////Problem 13.Extract students by marks

            Console.WriteLine();
            Console.WriteLine("Problem 13:");
            foreach (var name in Marks(student, 6))
            {
                Console.WriteLine($"{name.FullName} - marks: {string.Join(", ", name.Marks.ToArray())}");
            }

            ////Problem 14.Extract students with two marks

            Console.WriteLine();
            Console.WriteLine("Problem 14:");
            foreach (var name in student.studentsMarks(2))
            {
                Console.WriteLine($"{name.FullName} - Marks: {string.Join(", ", name.Marks.ToArray())}");
            }

            ////Problem 15.Extract marks

            Console.WriteLine();
            Console.WriteLine("Problem 15:");
            foreach (var name in student.fnExtractMarks())
            {
                extStudentsLINQ.Add(name);
                Console.WriteLine($"{name.FirstName} {name.LastName} - Marks: {string.Join(", ", name.Marks.ToArray())}");
            }

            ////Problem 16. Groups

            List<Group> groups = new List<Group>()
            {
                new Group(1, "History"),
                new Group(2, "Philology"),
                new Group(3, "Mathematics"),
                new Group(4, "Science")
            };

            Console.WriteLine();
            Console.WriteLine("Problem 16:");
            foreach (var name in Mathematics(student, groups))
            {
                Console.WriteLine($"{name.FirstName} {name.LastName} - group {name.GroupNumber}");
            }

            ////Problem 17.Longest string

            Console.WriteLine();
            Console.WriteLine("Problem 17:");
            List<string> strings = new List<string> { "aadfdsgf", "dsfaave", "dxcsas", "cfvv gsvgzxdv ", "dcfdec", "sdc", "pooirjvkjbdvsc czz" };
            Console.WriteLine($"Longest string: {LongestString(strings)}");

            ////Problem 18.Grouped by GroupNumber

            Console.WriteLine();
            Console.Write("Select Group: ");
            byte groupNumber = byte.Parse(Console.ReadLine());
            foreach (var name in Grouped(student, groupNumber))
            {
                Console.WriteLine($"{name.FirstName} {name.LastName} - group {name.GroupNumber}");
            }

            ////Problem 19.Grouped by GroupName extensions

            foreach (var name in student.grouped(groupNumber))
            {
                Console.WriteLine($"{name.FirstName} {name.LastName} - group {name.GroupNumber}");
            }
        }

        public static IEnumerable<Student> StudentsGroup_LINQ(List<Student> students, byte gr)
        {
            var subset = from name in students
                         where name.GroupNumber == gr
                         orderby name.FirstName,
                         (name.FirstName).Length
                         select name;
            return subset;
        }

        public static IEnumerable<Student> Email_LINQ(List<Student> students)
        {
            var subset = from name in students
                         where name.Email.Contains("@abv.bg")
                         select name;
            return subset;
        }

        public static IEnumerable<Student> SofiaPhoneNumbers(List<Student> students)
        {
            var subset = from name in students
                         where name.Tel.Contains("+3592")
                         select name;
            return subset;
        }

        public static List<dynamic> Marks(List<Student> students, byte mark)
        {
            var subset = from name in students
                         where name.Marks.Contains(mark)
                         select new
                         {
                             FullName = $"{name.FirstName} {name.LastName}",
                             Marks = name.Marks
                         };
            return subset.ToList<dynamic>();
        }

        public static IEnumerable<Student> Mathematics(List<Student> students, List<Group> grp)
        {
            var subset = from name in students
                         join gr in grp on name.GroupNumber equals gr.GroupNumber
                         where gr.DepartmentName == "Mathematics"
                         select name;
            return subset;
        }

        public static string LongestString(List<string> strings)
        {
            var subset = from str in strings
                         orderby str.Length descending
                         select str;
            return subset.First().ToString();
        }

        public static IEnumerable<Student> Grouped(List<Student> students, byte groupNumber)
        {
            var subset = from name in students
                         where name.GroupNumber == groupNumber
                         select name;
            return subset;
        }
    }
}
