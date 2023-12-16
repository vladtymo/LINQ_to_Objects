using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_anon_types
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GroupId { get; set; }
    }
    class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Group> groups = new List<Group>
                {
                     new Group { Id = 1, Name = "27PPS11" },
                     new Group { Id = 2, Name = "27PPS12" }
                };

            List<Student> students = new List<Student>
                {
                     new Student { FirstName = "John", LastName = "Miller", GroupId = 2 },
                     new Student { FirstName = "Candice", LastName = "Leman", GroupId = 1 },
                     new Student { FirstName = "Joey", LastName = "Finch", GroupId = 3 },
                     new Student { FirstName = "Nicole", LastName = "Taylor", GroupId = 2 }
                };

            var result = students.Select(x => new
            {
                Name = x.FirstName,
                Group = x.GroupId
            });

            var query = from g in groups
                        join st in students on g.Id
                        equals st.GroupId
                        select new
                        {
                            FirstName = st.FirstName,
                            LastName = st.LastName,
                            GroupName = g.Name
                        };

            var query2 = students.Select(s => new
            {
                Name = s.FirstName,
                Surname = s.LastName,
                In = $"{s.FirstName[0]}.{s.LastName[0]}"
            });

            Console.WriteLine("\tStudents in groups:");

            foreach (var item in query2)
            {
                Console.WriteLine(item);
            }
        }
    }
}