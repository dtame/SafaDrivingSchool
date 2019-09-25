using System;

namespace SafaEngine.Core
{
    public class Paiement
    {
        public int StudentID { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime TimeStamp { get; set; }
        public double Amount { get; set; }
        public bool PaiementDone { get; set; }
        public string Description { get; set; }
    }
}
