namespace Object_Oriented_Design
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Timetable timetable = new Timetable();
            timetable.AddCourse("M122", "Maths", 227);
            timetable.AddStudent("Ilias Fhail");
            timetable.AddTeacher("Ms Dillon");
        }
    }
}
