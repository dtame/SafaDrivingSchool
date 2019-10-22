namespace SafaEngine.Core
{
    public class Ennumarations
    {
        public enum CourseState
        {
           PLANNED = 1
           ,CONFIRMED = 2
           ,NOTCONFIRMED = 3
           ,MISSED = 5
           ,DONE = 4
           ,UNDEFINIED = 0
        }

        public enum CourseType
        {
            THEORIC
           ,DRIVINGSESSION
        }

        public enum ProgramType
        {
            STANDARD = 1
           ,CUSTOM = 2
        }

        public enum UserRole
        {
            STUDENT
            ,INSTRUCTOR
            ,ADMIN
        }
    }
}
