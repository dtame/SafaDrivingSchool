
using SafaDriving.Core;

namespace SafaDriving.Web.Data
{
    public interface IUnitOfWork
    {        
        IRepository<Course> Courses { get; }
        IRepository<Phase> Phases { get; }
        IRepository<Paiement> Paiements { get; }
        IRepository<DrivingProgram> DrivingPrograms { get; }
        IRepository<EventSchedule> EventSchedules { get; }
        IRepository<CourseEvent> CourseEvents { get; }
        IRepository<CourseSchedule> CourseSchedules { get; }
        /// <summary>
        /// Commits all changes
        /// </summary>
        void Save();

        void RejectChanges();
        /// <summary>
        /// Discards all changes that has not been commited
        /// </summary>        
        void Dispose();
    }
}
