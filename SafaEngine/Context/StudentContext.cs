using System;
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

        public PaiementProfile PaiementProfile { get; set; }
    }
}
