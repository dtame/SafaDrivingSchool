﻿using System.Collections.Generic;

namespace SafaEngine.Calendar
{
    /// <summary>
    /// Planning / Calender of a user 
    /// </summary>
    public class CourseSchedule
    {        
        public int CourseScheduleID { get; set; }
        public int StudentID { get; set;  }
        public bool HasLearnersLicence { get; set; }
        
    }
}
