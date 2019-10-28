using SafaDriving.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafaDriving.Web.Models
{
    public interface IProgramTimeline
    {

    }

    public class StudentBuilder
    {
        private ApplicationUser applicationUser;
        private DrivingProgram drivingProgram;
        private IProgramTimeline timeline;

        public StudentBuilder(ApplicationUser user, DrivingProgram program)
        {
            applicationUser = user;
            drivingProgram = program;
        }

        public void Build()
        {

        }
    }
}
