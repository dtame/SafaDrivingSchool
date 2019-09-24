using System.Collections.Generic;

namespace SafaEngine
{
    public abstract class DrivingProgram
    {
        protected string Name { get; set; }
        public List<Phase> Phases { get; set; } 
        protected double Price { get; set; } 
    }
}
