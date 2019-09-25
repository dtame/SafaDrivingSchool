namespace SafaEngine.Core
{
    public class Ennumarations
    {
        public enum CourseState
        {
           PLANNED
           ,CONFIRMED
           ,NOTCONFIRMED
           ,MISSED
           ,DONE
        }

        public enum CourseType
        {
            THEORIC
           ,DRIVINGSESSION
        }

        public enum ProgramType
        {
            STANDARD
           ,CUSTOM
        }

        public enum UserRole
        {
            STUDENT
            ,INSTRUCTOR
            ,ADMIN
        }
    }
}
