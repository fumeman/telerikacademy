namespace Students
{
    using System.Collections.Generic;
    using System.Linq;

    public static class Extentions
    {
        public static IEnumerable<Student> studentsGroup_Lambda(this List<Student> students, byte group)
        {
            var subset = students
                        .Where(name => (name.GroupNumber == group))
                        .OrderBy(name => (name.FirstName))
                        .ThenBy(name => (name.FirstName).Length)
                        .Select(name => name);
            return subset;
        }

        public static IEnumerable<Student> studentsGroup_LINQ(this List<Student> students, byte gr)
        {
            var subset =
                         from name in students
                         where (name.GroupNumber == gr)
                         orderby (name.FirstName),
                         (name.FirstName).Length
                         select name;
            return subset;
        }

        public static List<dynamic> studentsMarks(this List<Student> students, int marksCount)
        {
            var subset =
                         from name in students
                         where name.Marks.Count == marksCount
                         orderby name.FirstName,
                         (name.FirstName).Length
                         select new
                         {
                             FullName = $"{name.FirstName} {name.LastName}",
                             Marks = name.Marks
                         };
            return subset.ToList<dynamic>();
        }

        public static IEnumerable<Student> fnExtractMarks(this List<Student> students)
        {
            var subset =
                         from name in students
                         where (name.FN / 10000) % 100 == 6
                         orderby name.FirstName,
                         (name.FirstName).Length
                         select name;
            return subset;
        }

        public static IEnumerable<Student> grouped(this List<Student> students, byte groupNumber)
        {
            var subset = from name in students
                         where name.GroupNumber == groupNumber
                         select name;
            return subset;
        }
    }
}
