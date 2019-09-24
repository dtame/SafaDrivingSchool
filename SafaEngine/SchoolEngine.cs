using System;
using static SafaEngine.Ennumarations;

namespace SafaEngine
{
    public class SchoolEngine
    {

    }

    public class CourseScheduler
    {
        public bool SetCourseState(int course, int studentId, CourseState newStateOfCourse)
        {
            return false;
        }
    }

    public class StudentContext
    {
        public int ID { get; set; }
        public DateTime RegistrationDate { get; set; }
        public UserProfile Profile { get; set; }

        public DrivingProgram Program { get; set; }

        public PaiementProfile PaiementProfile { get; set; }
    }
}
