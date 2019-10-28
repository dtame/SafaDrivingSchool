using System;

namespace SafaDriving.Core
{
    public class Paiement
    {
        public int ID { get; set; }
        public int StudentID { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime TimeStamp { get; set; }
        public decimal Amount { get; set; }
        public bool PaiementDone { get; set; }
        public string Description { get; set; }
    }
}
