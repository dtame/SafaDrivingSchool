using static SafaEngine.Core.Ennumarations;

namespace SafaEngine.Core
{
    public class Course
    {
        public int ID { get; set; }
        public int SeqNumber { get; set; }        
        public string Title { get; set; }
        public CourseType Type { get; set; }

        public int PhaseId { get; set; }
    }
}
