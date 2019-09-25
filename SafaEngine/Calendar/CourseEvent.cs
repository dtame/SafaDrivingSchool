using static SafaEngine.Core.Ennumarations;

namespace SafaEngine.Calendar
{
    /// <summary>
    /// event for a course to be displayed on calendar
    /// </summary>
    public class CourseEvent : EventSchedule
    {
        public CourseEvent(int courseId, int studentId)
        {
            CanBeModifyByOthers = true;
            CourseID = courseId;
            StudentID = studentId;
        }        
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public CourseState Status { get; set; }
        public int AssignToId { get; set; } 
        public int InitById { get; set; }
    }
}
