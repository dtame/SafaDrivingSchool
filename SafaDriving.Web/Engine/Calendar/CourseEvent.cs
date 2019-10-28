using System;

namespace SafaDriving.Web.Engine.Calendar
{
    /// <summary>
    /// event for a course to be displayed on calendar
    /// </summary>
    public class CourseEvent
    {
        public CourseEvent() { }
        public CourseEvent(int courseId, int studentId)
        {
            CanBeModifyByOthers = true;
            CourseID = courseId;
            StudentID = studentId;
        }
        public int ID { get; set; }

        /// <summary>
        /// Creation date of the event
        /// </summary>
        public DateTime? Date { get; set; }
        public string Description { get; set; }
        public bool CanBeModifyByOthers { get; set; } = false;
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public int Status { get; set; }
        public int? AssignToId { get; set; } 
        public int? InitById { get; set; }
    }
}
