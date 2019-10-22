using System;
using System.Collections.Generic;
using SafaEngine.Calendar;
using SafaEngine.Context;
using SafaEngine.Core;
using static SafaEngine.Core.Ennumarations;

namespace SafaEngine.Context
{
    public class StudentContext : BaseContext
    {
        public StudentContext()
        {
            Role = UserRole.STUDENT;
        }
        public DateTime RegistrationDate { get; set; }        

        public DrivingProgram Program { get; set; }

        public PaiementPlanner PaiementProfile { get; set; }
        public List<EventSchedule> StudentSchedule { get; set; }
    }
}
