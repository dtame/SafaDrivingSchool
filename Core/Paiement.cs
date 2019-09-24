using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Paiement
    {
        public Guid ID { get; set; }
        public Guid ProgramID { get; set; }
        public Guid StudentID { get; set; }
        public DateTime PaiementDate { get; set; }
        public double Amount { get; set; }
    }
}
