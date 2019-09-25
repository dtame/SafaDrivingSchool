using System.Collections.Generic;
using static SafaEngine.Core.Ennumarations;

namespace SafaEngine.Core
{
    public class StandardProgram : DrivingProgram
    {
        public StandardProgram()
        {
            //all the meta properties should be store in db [ name, price]
            Name = "RSEP (Complete Driving Course)";
            Price = 699;
            Phases.Add(
                new Phase {
                    Name = "Phase 1"
                    , Description = "Prerequisite for a learner's licence"
                    , Courses = new List<Course> {
                        new Course{ Title="The Vehicle", SeqNumber = 1, Type = CourseType.THEORIC }
                       ,new Course{ Title="The Driver", SeqNumber = 2, Type = CourseType.THEORIC }
                       ,new Course{ Title="The Environment", SeqNumber = 3, Type = CourseType.THEORIC }
                       ,new Course{ Title="At-Risk Behaviours", SeqNumber = 4, Type = CourseType.THEORIC }
                       ,new Course{ Title="Evaluation", SeqNumber = 5, Type = CourseType.THEORIC }
                    }
                });
            Phases.Add(
                new Phase {
                    Name = "Phase 2"
                    , Description = "Guided driving"
                    , Courses = new List<Course> {
                        new Course{ Title="Accompanied Driving", SeqNumber = 6, Type = CourseType.THEORIC }
                       ,new Course{ Title="In-Car session 1", SeqNumber = 7, Type = CourseType.DRIVINGSESSION }
                       ,new Course{ Title="In-Car session 2", SeqNumber = 8, Type = CourseType.DRIVINGSESSION }
                       
                       ,new Course{ Title="OEA Strategy", SeqNumber = 9, Type = CourseType.THEORIC }
                       ,new Course{ Title="In-Car session 3", SeqNumber = 10,Type = CourseType.DRIVINGSESSION }
                       ,new Course{ Title="In-Car session 4", SeqNumber = 11,Type = CourseType.DRIVINGSESSION }
                    }
                });

            Phases.Add(
                new Phase
                {
                    Name = "Phase 3"
                    , Description = "Semi-Guided Driving"
                    , Courses = new List<Course> {
                        new Course{ Title="Speed", SeqNumber = 12, Type = CourseType.THEORIC }
                       ,new Course{ Title="In-Car session 5", SeqNumber = 13, Type = CourseType.DRIVINGSESSION }
                       ,new Course{ Title="In-Car session 6", SeqNumber = 14, Type = CourseType.DRIVINGSESSION }
                       
                       ,new Course{ Title="Sharing the road", SeqNumber = 15, Type = CourseType.THEORIC }
                       ,new Course{ Title="In-Car session 7", SeqNumber = 16, Type = CourseType.DRIVINGSESSION }
                       ,new Course{ Title="In-Car session 8", SeqNumber = 17, Type = CourseType.DRIVINGSESSION }
                       
                       ,new Course{ Title="Alcohol and Drugs", SeqNumber = 18, Type = CourseType.THEORIC }
                       ,new Course{ Title="In-Car session 9", SeqNumber = 19, Type = CourseType.DRIVINGSESSION }
                       ,new Course{ Title="In-Car session 10", SeqNumber = 20, Type = CourseType.DRIVINGSESSION }
                    }
                });
            Phases.Add(
                new Phase
                {
                    Name = "Phase 4"
                    , Description = "Semi-Guided to Independent Driving"
                    , Courses = new List<Course> {
                        new Course{ Title="Fatigue and Distractions", SeqNumber = 21, Type = CourseType.THEORIC }
                       ,new Course{ Title="In-Car session 11", SeqNumber = 22, Type = CourseType.DRIVINGSESSION }
                       ,new Course{ Title="In-Car session 12", SeqNumber = 23, Type = CourseType.DRIVINGSESSION }                       
                       ,new Course{ Title="In-Car session 13", SeqNumber = 24, Type = CourseType.DRIVINGSESSION }
                       
                       ,new Course{ Title="Eco-Driving", SeqNumber = 25, Type = CourseType.THEORIC }
                       ,new Course{ Title="In-Car session 14", SeqNumber = 26, Type = CourseType.DRIVINGSESSION }
                       ,new Course{ Title="In-Car session 15", SeqNumber = 27, Type = CourseType.DRIVINGSESSION }
                    }
                });
        }
    }
}
