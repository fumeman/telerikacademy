namespace School
{
    using System;
    using System.Collections.Generic;

    class Startup
    {
        static void Main()
        {
            IList<Discipline> teacher1Disciplines = new List<Discipline>();
            teacher1Disciplines.Add(new Discipline(AllDisciplines.Bulgarian.ToString(), 20, 30));
            teacher1Disciplines.Add(new Discipline(AllDisciplines.Math.ToString(), 22, 35));
            teacher1Disciplines.Add(new Discipline(AllDisciplines.History.ToString(), 10, 20));
            Teacher teacher1 = new Teacher("Teacher 1", teacher1Disciplines);

            IList<Discipline> teacher2Disciplines = new List<Discipline>();
            teacher2Disciplines.Add(new Discipline(AllDisciplines.Englich.ToString(), 15, 20));
            teacher2Disciplines.Add(new Discipline(AllDisciplines.Deutsch.ToString(), 15, 20));
            Teacher teacher2 = new Teacher("Teacher 2", teacher2Disciplines);

            IList<Teacher> teachers1a = new List<Teacher>();
            teachers1a.Add(teacher1);
            teachers1a.Add(teacher2);

            foreach (var item in teachers1a)
            {
                Console.WriteLine(item.Name);
                foreach (var item1 in item.Disciplines)
                {
                    Console.Write($"{item1.Name} {item1.NumberOfExercises}, ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }

            Student student1 = new Student("gosho", 1);
            Student student2 = new Student("pesho", 2);
            Student student3 = new Student("tosho", 3);
            ////Student student4 = new Student("nesho", 1);  ////test isUniq

            IList<Student> students1a = new List<Student>();
            students1a.Add(student1);
            students1a.Add(student2);
            students1a.Add(student3);

            Class a1 = new Class("1a", teachers1a, students1a);
            ////Class b1 = new Class("1a", teachers1a, students1a); ////test isUniq

            foreach (var item in a1.Teachers)
            {
                Console.WriteLine($"{item.Name}");
            }

            Console.WriteLine();
            foreach (var item in a1.Students)
            {
                Console.WriteLine($"{item.Name} {item.ClassNumber}");
            }
        }
    }
}
