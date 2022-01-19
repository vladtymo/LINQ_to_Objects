using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        // ...
        public override string ToString()
        {
            return $"Surname: {LastName}, Name: {FirstName}, Born: { BirthDate.ToLongDateString()}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            const double daysOfYear = 365.25;

            List<Student> students = new List<Student>
            {
                 new Student {
                 FirstName = "John",
                 LastName = "Miller",
                 BirthDate = new DateTime(2001,3,12)
                 },
                        new Student {
                 FirstName = "Candice",
                 LastName = "Leman",
                 BirthDate = new DateTime(1998,7,22)
                 },
                 new Student {
                 FirstName = "Joey",
                 LastName = "Finch",
                 BirthDate = new DateTime(2007,1,30)
                 },
                 new Student {
                 FirstName = "Nicole",
                 LastName = "Taylor",
                 BirthDate = new DateTime(1996,1,10)
                 }
            };
            Console.WriteLine($"\tThe current date: { DateTime.Now.ToLongDateString()}\n");

            ////////////////Expressions in query
            //var query = from s in students
            //            where (DateTime.Now - s.BirthDate).Days / daysOfYear > 20
            //            select s;

            //Console.WriteLine("\tStudents older than 20 years:");

            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}

            ////////////////Expressions in method
            //Console.WriteLine($"\tThe current date: { DateTime.Now.ToLongDateString()}\n");
            //var query = students.Where(s =>
            //    (DateTime.Now - s.BirthDate).
            //    Days / daysOfYear > 20).Select(s => s);

            //Console.WriteLine("\tStudents older than 20 years:");
            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}

            ///////////////Combination of query + method
            Console.WriteLine($"\tThe youngest student:");

            var maxDate = students.Max(s => s.BirthDate);

            var student = from s in students
                          where s.BirthDate == maxDate
                              //(from b in students
                              // select b.BirthDate).Max()
                          select s;

            foreach (var item in student)
            {
                Console.WriteLine(item);
            }

            var minAge = (from s in students
                          select s).Min(s => (DateTime.Now - s.BirthDate).Days / daysOfYear);

            Console.WriteLine("Min age: " + minAge);
        }
    }
}
