namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        static void Main()
        {
            ////Students
            IList<Student> students = new List<Student>();
            students.Add(new Student("gosho", "goshev", 3.33));
            students.Add(new Student("tosho", "goshev", 2.90));
            students.Add(new Student("pesho", "toshev", 4.00));
            students.Add(new Student("gosho", "peshev", 6.00));
            students.Add(new Student("stamat", "stamatov", 4.55));
            students.Add(new Student("pena", "stamatova", 3.65));
            students.Add(new Student("mina", "minova", 4.20));
            students.Add(new Student("lina", "linova", 2.95));
            students.Add(new Student("tina", "tinova", 5.60));
            students.Add(new Student("nikoi", "nikoi", 5.50));

            IList<Student> orderedStudents = new List<Student>();
            foreach (var student in students.OrderBy(s => s.Grade))
            {
                orderedStudents.Add(student);
                Console.WriteLine(student.ToString());
            }

            ////Workers
            IList<Worker> workers = new List<Worker>();
            workers.Add(new Worker("gosho", "goshev", 333, 8));
            workers.Add(new Worker("tosho", "goshev", 290, 5));
            workers.Add(new Worker("pesho", "toshev", 400, 7));
            workers.Add(new Worker("gosho", "peshev", 600, 8));
            workers.Add(new Worker("stamat", "stamatov", 455, 6));
            workers.Add(new Worker("pena", "stamatova", 365, 4));
            workers.Add(new Worker("mina", "minova", 420, 6));
            workers.Add(new Worker("lina", "linova", 295, 3));
            workers.Add(new Worker("tina", "tinova", 560, 8));
            workers.Add(new Worker("nikoi", "nikoi", 800, 8));

            IList<Worker> orderedWorkers = new List<Worker>();

            Console.WriteLine();
            foreach (var worker in workers.OrderByDescending(s => s.MoneyPerHour()))
            {
                orderedWorkers.Add(worker);
                Console.WriteLine(worker.ToString());
            }

            List<Human> humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);
            Console.WriteLine();
            IList<Human> sotredList = humans.OrderBy(h => h.FirstName).ThenBy(h => h.LastName).ToList();
            foreach (var human in sotredList)
            {
                Console.WriteLine($"{human.FirstName} {human.LastName}");
            }
        }
    }
}
