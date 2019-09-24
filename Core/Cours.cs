using System;

namespace Core
{
    public class Cours
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid ProgramParent { get; set; }
        public Guid CoursParent { get; set; }
        public int SeqNum { get; set; }
        public string Type { get; set; }
    }
}
