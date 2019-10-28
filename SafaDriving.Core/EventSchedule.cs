using System;

namespace SafaDriving.Core
{
    /// <summary>
    /// Object to manipulate in calendar. 
    /// </summary>
    public class EventSchedule
    {
        public int ID { get; set; }
        public DateTime EventDate { get; set; }
        public string Description { get; set; }
        public bool CanBeModifyByOthers { get; set; } = false;
        public int CourseScheduleID { get; set; }
    }
}
