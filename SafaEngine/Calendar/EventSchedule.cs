using System;

namespace SafaEngine.Calendar
{
    /// <summary>
    /// Object to manipulate in calendar. 
    /// </summary>
    public abstract class EventSchedule
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public bool CanBeModifyByOthers { get; set; } = false;
    }
}
