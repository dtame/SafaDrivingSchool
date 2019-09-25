using System;

namespace SafaEngine.Calendar
{
    /// <summary>
    /// Event to set hollidays, only the admin can add/delete it. Does need any validation 
    /// </summary>
    public class HollidayEvent : EventSchedule
    {
        public HollidayEvent(DateTime date, string description)
        {
            Date = date;
            Description = description;
        }
    }
}
