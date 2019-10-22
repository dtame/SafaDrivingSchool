using System.Collections.Generic;

namespace SafaEngine.Core
{
    public class DrivingProgram
    {
        public int ID { get; set; }
        public string Name { get; set; }        
        public decimal Price { get; set; }
        public virtual List<Phase> Phases { get; set; }
    }
}
