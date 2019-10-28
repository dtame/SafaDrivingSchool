using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SafaDriving.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafaDriving.Web.Data
{

    public class ApplicationDAL : IUnitOfWork
    {
        private readonly ApplicationDbContext context;
        public ApplicationDAL(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;
        
        public IRepository<Course> Courses => new Repository<Course>(context);

        public IRepository<Phase> Phases => new Repository<Phase>(context);

        public IRepository<Paiement> Paiements => new Repository<Paiement>(context);

        public IRepository<DrivingProgram> DrivingPrograms => new Repository<DrivingProgram>(context);
        public IRepository<EventSchedule> EventSchedules => new Repository<EventSchedule>(context);

        public IRepository<CourseSchedule> CourseSchedules => new Repository<CourseSchedule>(context);

        public IRepository<CourseEvent> CourseEvents => new Repository<CourseEvent>(context);

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void RejectChanges()
        {
            foreach (var entry in context.ChangeTracker.Entries()
                  .Where(e => e.State != EntityState.Unchanged))
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Modified:
                    case EntityState.Deleted:
                        entry.Reload();
                        break;
                }
            }
        }
    }
}
