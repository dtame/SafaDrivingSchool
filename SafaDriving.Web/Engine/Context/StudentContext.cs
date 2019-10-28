using System;
using System.Collections.Generic;
using System.Linq;
using SafaDriving.Core;
using SafaDriving.Web.Data;
using SafaDriving.Web.Models;
using SafaDriving.Web.Models.StudentViewModels;


namespace SafaDriving.Web.Engine.Context
{
    public class StudentContext : BaseContext
    {
        private IUnitOfWork unitOfWork;
        private ApplicationUser applicationUser;
        public StudentContext(ApplicationUser user, IUnitOfWork unit)
        {
            unitOfWork = unit;
            applicationUser = user;
            Role = UserRole.Student;
        }
        public DateTime RegistrationDate { get; set; }        

        public DrivingProgram Program {
            get
            {
                return unitOfWork.DrivingPrograms.Get(x => x.ID == applicationUser.ProgramID, null, "Phase, Course").First();
            }
        }

        //public PaiementPlanner PaiementProfile { get; set; }
        public List<CourseEvent> CourseSchedule {
            get
            {
                return unitOfWork.CourseEvents.Get(x => x.StudentID == Int32.Parse(applicationUser.Id)).ToList();
            }
        }

        public StudentViewModel GetViewModel()
        {
            StudentViewModel viewModel = new StudentViewModel();
            return viewModel;
        }
    }
}
