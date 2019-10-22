using SafaDriving.Web.Data;
using SafaEngine.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static SafaEngine.Core.Ennumarations;

namespace SafaDriving.Web.Models
{
    public class Timeline
    {
        private int StudentID { get; set; }
        private IUnitOfWork unitOfWork;
        public Timeline(int studentID, IUnitOfWork work)
        {
            StudentID = studentID;
            unitOfWork = work;
        }

        public Phase GetCurrentPhase()
        {
            Phase phase = new Phase();
            unitOfWork.CourseEvents.Get();
            return phase;
        }

        public bool IsPhaseDone(int phaseSequence)
        {
            List<Course> courses = unitOfWork.Courses.Get(x => x.PhaseId == phaseSequence).ToList();

            bool response = false;
            unitOfWork.CourseEvents.Get(x => x.StudentID == StudentID && courses.x.CourseID)
            return response;
        }
    }
}
