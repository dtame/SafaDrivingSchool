using System.Collections.Generic;

namespace SafaEngine
{
    public class Phase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();
    }
}
