using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    public class City
    {
        public City(string name, string region)
        {
            Name = name;
            Region = region;
            Schools = new List<School>();
        }

        public string Name { get; set; }
        public string Region { get; set; }
        public List<School> Schools { get; set; }

    public class School
    {
        public School(string schoolName, int space)
            {
                SchoolName = schoolName;
                Space = space;
                Teachers = new List<Teacher>();
            }

        public string SchoolName { get; set; }
        public int Space { get; set; }

        public List<Teacher> Teachers { get; set; }
    }

    public class Teacher

    {
        public Teacher(string teacherName, int teacherID)
            {
                TeacherName = teacherName;
                TeacherId=teacherID;
            }
        public string TeacherName { get; set; }
        public int TeacherId { get; set; }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
                
                 City city1 = new City ("Zarqa", "MID Region");

                School school1 = new School ("King Abdullah School for Excellence - Zarqa", 1000 );
                school1.Teachers.Add(new Teacher ( "Ziad Adnan", 1));
                school1.Teachers.Add(new Teacher("Bader Ratroot", 2));

                School school2 = new School ( "Al Shamelah", 1500);
                school2.Teachers.Add(new Teacher ( "Rami Al haj",3 ));

                city1.Schools.Add(school1);
                city1.Schools.Add(school2);
                
                //Showing Schools
                Console.WriteLine($"City: {city1.Name}, Region: {city1.Region}");
                city1.Schools.ForEach(school =>
                {
                    Console.WriteLine($"  School: {school.SchoolName}, Space: {school.Space}");
                    school.Teachers.ForEach(teacher => Console.WriteLine($"    Teacher: {teacher.TeacherName}, ID: {teacher.TeacherId}"));
                });


                //the school with the highest number of teachers
                School schoolWithMostTeachers = city1.Schools.OrderByDescending(s => s.Teachers.Count).First();
                Console.WriteLine($"\nSchool with the highest number of teachers: {schoolWithMostTeachers.SchoolName}, Number of teachers: {schoolWithMostTeachers.Teachers.Count}");
                
            }
        }
    }
}
