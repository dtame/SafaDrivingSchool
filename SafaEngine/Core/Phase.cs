using System.Collections.Generic;

namespace SafaEngine.Core
{
    public class Phase
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Seq { get; set; }
        public int ProgramID { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();
    }
}
