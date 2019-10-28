using Microsoft.Extensions.Logging;
using SafaDriving.Web.Data;
using SafaDriving.Web.Engine.Calendar;
using System;
using System.Collections.Generic;

namespace SafaDriving.Web.Engine
{
    public class CourseScheduler
    {
        private readonly ILogger _logger;
        private IUnitOfWork dal;
        public CourseScheduler(ILogger<CourseScheduler> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            dal = unitOfWork;
        }

        public List<CourseEvent> GetStudentSchedule(int studentId)
        {
            List<CourseEvent> events = new List<CourseEvent>();
            //TODO : get from the db all events create by and assign to this student + all the hollidays(non editable)
            return events;
        }

        public List<CourseEvent> GetAdminSchedule(int student)
        {
            List<CourseEvent> events = new List<CourseEvent>();
            //TODO : get from the db all events create by and assign to this student + all the hollidays(editable)
            return events;
        }        

        public bool SetCourseState(int course, int studentId, CourseState newStateOfCourse)
        {
            //TODO : get courseevent from db and update status
            return false;
        }

        private void CreateStudentEvent(int studentId, DateTime dateEvent, string description, int createById, int assignToId, int courseId)
        {
            CourseEvent courseEvent = new CourseEvent(courseId, studentId);
            courseEvent.AssignToId = assignToId;
            courseEvent.Date = dateEvent;
            courseEvent.Description = description;
            courseEvent.Status = (int)CourseState.PLANNED;

            //TODO : save to db
        }

        private void CreateHollidayEvent(DateTime dateEvent, string description)
        {
            //HollidayEvent hollidayEvent = new HollidayEvent(date: dateEvent, description: description);
            //TODO : save to db
        }

        private void DeleteEvent(int eventID)
        {
            //1. get the event from db

            //2. validation
            // if it is courseEvent and status is planned so it can be deleted
            // if it is hollidayEvent it can be deleted 
        }
    }
}
