using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Object_Oriented_Design.Timetable;

namespace Object_Oriented_Design
{
    public class Timetable
    {
        public class Course
        {
            public string CourseCode { get; set; }
            public string CourseName { get; set; }
            public int RoomNumber { get; set; }

            public Course(string code, string name, int number)
            {
                CourseCode = code;
                CourseName = name;
                RoomNumber = number;
            }
        }

        public class Teacher
        {
            public string TeacherName { get; set; }

            public Teacher(string name)
            {
                TeacherName = name;
            }
        }
        public class Student
        {
            public string StudentName { get; set; }

            public Student(string name)
            {
                StudentName = name;
            }
        }

        private Dictionary<string, Course> Courses { get; set; }
        private Dictionary<string, Teacher> Teachers { get; set; }
        private Dictionary<string, Student> Students { get; set; }
        private Dictionary<string, string> Schedule { get; set; }

        public Timetable()
        {
            Courses = new Dictionary<string, Course>();
            Teachers = new Dictionary<string, Teacher>();
            Students = new Dictionary<string, Student>();
            Schedule = new Dictionary<string, string>();
        }
        public void AddCourse(string code, string name, int number)
        {
            Courses.Add(code, new Course(code, name, number));
            Console.WriteLine("Course " + code + " added successfully.");
        }
        public void AddStudent(string studentName)
        {
            Students.Add(studentName, new Student(studentName));
            Console.WriteLine("Student " + studentName + " added successfully.");
        }
        public void AddTeacher(string teacherName)
        {
            Teachers.Add(teacherName, new Teacher(teacherName));
            Console.WriteLine("Student " + teacherName + " added successfully.");
        }
    }
}
