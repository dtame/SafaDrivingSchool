using System.Collections.Generic;

namespace SafaEngine.Calendar
{
    /// <summary>
    /// Planning / Calender of a user 
    /// </summary>
    public class CourseSchedule
    {
        List<EventSchedule> Events = new List<EventSchedule>(); 
        public CourseSchedule(int userID)
        {
            //TODO : Load events from bd
        }
    }
}
