﻿using System;

namespace SafaEngine.Calendar
{
    /// <summary>
    /// Event to set hollidays, only the admin can add/delete it. Does need any validation 
    /// </summary>
    public class HollidayEvent
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public bool CanBeModifyByOthers { get; set; } = false;

        public HollidayEvent(DateTime date, string description)
        {
            Date = date;
            Description = description;
        }
    }
}
